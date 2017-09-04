﻿using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PSN.API;
using PSN.Responses;
using PSN.Extensions;
using System;
using System.Collections.Generic;

namespace PSN.API
{
    /// <summary>
    /// Contains information for the currently logged in account.
    /// </summary>
    public class Account
    {
        public OAuthTokens AccountTokens { get; set; }
        public ProfileResponse Profile { get; protected set; }

        public Account(OAuthTokens tokens)
        {
            AccountTokens = tokens;
            Profile = GetInfo();
        }

		public enum StatusFilter
		{
			Online,
			All

		}

        private ProfileResponse GetInfo()
        {
            var response = Utilities.SendGetRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/users/me/profile2?fields=npId,onlineId,avatarUrls,plus,aboutMe,languagesUsed,trophySummary(@default,progress,earnedTrophies),isOfficiallyVerified,personalDetail(@default,profilePictureUrls),personalDetailSharing,personalDetailSharingRequestMessageFlag,primaryOnlineStatus,presences(@titleInfo,hasBroadcastData),friendRelation,requestMessageFlag,blocking,mutualFriendsCount,following,followerCount,friendsCount,followingUsersCount&avatarSizes=m,xl&profilePictureSizes=m,xl&languagesUsedLanguageSet=set3&psVitaTitleIcon=circled&titleIconSize=s",
                this.AccountTokens.Authorization);

            //bleck
            var responseJson = response.ReceiveJson().Result;
            var responseString = response.ReceiveString().Result;

            if (Utilities.ContainsKey(responseJson, "error"))
                throw new Exception(responseJson.error.message);

            //Remove root "profile" element
            return JsonConvert.DeserializeObject<ProfileResponse>(JObject.Parse(responseString).SelectToken("profile").ToString());
        }

        /// <summary>
        /// Adds a friend to your friends list.
        /// </summary>
        /// <param name="psn">The PSN online ID of the friend to add.</param>
        /// <param name="requestMessage">A message to send with the friend request. Optional.</param>
        /// <returns>True if the user was added successfully.</returns>
        public bool AddFriend(string psn, string requestMessage = "")
        {
            object message = (string.IsNullOrEmpty(requestMessage)) ? new object() : new
            {
                requestMessage = requestMessage
            };
            var response = Utilities.SendJsonPostRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/users/{this.Profile.onlineId}/friendList/{psn}",
                message, this.AccountTokens.Authorization).ReceiveJson().Result;

            if (Utilities.ContainsKey(response, "error"))
                throw new Exception(response.error.message);

            return true;
        }

        /// <summary>
        /// Removes a friend from your friends list.
        /// </summary>
        /// <param name="psn">The PSN online ID to remove.</param>
        /// <returns>True if the friend was removed successfully.</returns>
        public bool RemoveFriend(string psn)
        {
            var response = Utilities.SendDeleteRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/users/{this.Profile.onlineId}/friendList/{psn}",
                this.AccountTokens.Authorization).ReceiveJson().Result;

            if (Utilities.ContainsKey(response, "error"))
                throw new Exception(response.error.message);

            return true;
        }

        /// <summary>
        /// Fetches each friend of the logged in account.
        /// </summary>
        /// <param name="filter">A filter to grab online or all friends. Defaults to online.</param>
        /// <param name="limit">The amount of friends to return. By default, the PSN app uses 36.</param>
        /// <returns>A list of User objects for each friend.</returns>
        public List<User> GetFriends(StatusFilter filter = StatusFilter.Online, int limit = 36)
        {
            List<User> friends = new List<User>();

			var filterQuery = "";
			if (filter == StatusFilter.Online)
			{
				filterQuery = "&userFilter=online";
			}

            var response = Utilities.SendGetRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/users/me/friends/profiles2?fields=onlineId,avatarUrls,plus,trophySummary(@default),isOfficiallyVerified,personalDetail(@default,profilePictureUrls),primaryOnlineStatus,presences(@titleInfo,hasBroadcastData)&sort=name-onlineId{filterQuery}&avatarSizes=m&profilePictureSizes=m&offset=0&limit={limit}",
                this.AccountTokens.Authorization).ReceiveJson<FriendsResponse>().Result;

            foreach (ProfileResponse friend in response.Profiles)
            {
                friends.Add(new User(friend));
            }

            return friends;
        }

        /// <summary>
        /// Blocks a user.
        /// </summary>
        /// <param name="psn">The PSN online ID to block.</param>
        /// <returns>True if the user was blocked.</returns>
        public bool BlockUser(string psn)
        {
            //This service requires the request to be a JSON POST request... not sure why it doesn't accept GET or PUT. So I'll just pass null for the data.
            var response = Utilities.SendJsonPostRequest($"{APIEndpoints.USERS_URL}{this.Profile.onlineId}/blockList/{psn}",
                null, this.AccountTokens.Authorization).ReceiveJson().Result;

            //Since we pass null for the JSON POST data, the response likes to be null too...
            if (Utilities.ContainsKey(response, "error"))
                throw new Exception(response.error.message);

            return true;
        }

        /// <summary>
        /// Unblocks a user.
        /// </summary>
        /// <param name="psn">The PSN online ID to unblock.</param>
        /// <returns>True if user was unblocked.</returns>
        public bool UnblockUser(string psn)
        {
            var response = Utilities.SendDeleteRequest($"{APIEndpoints.USERS_URL}{this.Profile.onlineId}/blockList/{psn}",
                this.AccountTokens.Authorization).ReceiveJson().Result;

            if (Utilities.ContainsKey(response, "error"))
                throw new Exception(response.error.message);

            return true;
        }

        /// <summary>
        /// Sets your current avatar. You must own the avatar for this to set.
        /// </summary>
        /// <param name="contentId">The content ID/entitlement ID of the avatar. (ex: "UP4478-CUSA01744_00-AV00000000000059")</param>
        /// <returns>True if avatar is set successfully. Throws an exception otherwise.</returns>
        public void SetAvatar(string contentId)
        {
            //TODO: Find out why this endpoint constantly gives the "Not Authorized" error...
            //Update 8/28/2016: I know why this happens, but it's not a big enough problem to make a workaround
            //Basically the avatar requests require specific permissions that the regular auth token doesn't have
            //So you need to generate a new set of tokens that have permissions to make requests to the avatar enpoints. Dumb, I know.

            //var response = await Utilities.SendPutRequest($"{APIEndpoints.USERS_URL}me/avatar", new AvatarRequest(contentId), this.AccountTokens.Authorization).ReceiveJson();

            //if (Utilities.ContainsKey(response, "error"))
            //    throw new Exception(response.error.message);

            //return true;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all avatars for the user.
        /// </summary>
        /// <param name="category">Category to get the avatars from.</param>
        /// <param name="offset">The amount of avatars to skip (optional).</param>
        /// <param name="limit">The amount of avatars to show (optional).</param>
        /// <param name="avatarSizes">The size of the avatar to show (optional).</param>
        /// <returns></returns>
        public void GetAvatars(AvatarCategoryId category, int offset = 0, int limit = 48, char avatarSizes = 'm')
        {
            //TODO: Find out why this endpoint constantly gives the "Not Authorized" error...
            //Update 8/28/2016: See above method.

            //var response = await Utilities.SendGetRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/avatars/categories/{ (int)category }?offset={offset}&limit={limit}&avatarSizes={avatarSizes}", this.AccountTokens.Authorization).ReceiveString();

            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches each category of avatars (Premium, Action, etc).
        /// </summary>
        /// <param name="offset">The amount of categories to skip (optional).</param>
        /// <param name="limit">The amount of categories to show (optional).</param>
        /// <returns>An AvatarCategories object containing a list of all categories.</returns>
        public AvatarCategoriesResponse GetAvatarCategories(int offset = 0, int limit = 64)
        {
            //This response shouldn't ever throw an error even if the auth token is invalid. It just won't return then 'Premium Avatars' category.
            var response = Utilities.SendGetRequest($"https://us-prof.np.community.playstation.net/userProfile/v1/avatars/categories?offset={offset}&limit={limit}",
                this.AccountTokens.Authorization).ReceiveJson<AvatarCategoriesResponse>().Result;

            return response;
        }

        /// <summary>
        /// Fetches the user's trophies.
        /// </summary>
        /// <param name="limit">The amount of trophies to return (optional).</param>
        /// <returns></returns>
        public TrophyResponses.UserTrophiesResponse GetTrophies(int limit = 36)
        {
            var response = Utilities.SendGetRequest($"https://us-tpy.np.community.playstation.net/trophy/v1/trophyTitles?fields=@default&npLanguage=en&iconSize=m&platform=PS3,PSVITA,PS4&offset=0&limit={limit}",
                this.AccountTokens.Authorization).ReceiveJson<TrophyResponses.UserTrophiesResponse>().Result;

            return response;
        }

        /// <summary>
        /// Deletes the game from showing up under the user's trophies list (only works if the game has 0% of trophies obtained).
        /// </summary>
        /// <param name="gameContentId">The content Id of the game. (ex: NPWR07466_00)</param>
        /// <returns>True if the trophy was successfully deleted.</returns>
        public bool DeleteTrophy(string gameContentId)
        {
            var response = Utilities.SendDeleteRequest($"https://us-tpy.np.community.playstation.net/trophy/v1/users/{ this.Profile.onlineId }/trophyTitles/{ gameContentId }",
                this.AccountTokens.Authorization).ReceiveJson().Result;

            if (Utilities.ContainsKey(response, "error"))
                throw new Exception(response.error.message);

            return true;
        }
    }
}