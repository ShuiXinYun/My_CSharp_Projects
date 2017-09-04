using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSN.API;
using CsvHelper;


namespace PSN.ProfileFetch
{

    public class profile_fetch
    {
        public string[] friend_ids { get; set; }
        public string[] avatar_urls { get; set; }
        public List<User> account_friends { get; set; }
        public List<string[]> friends_data = new List<string[]>();

        public profile_fetch(Account useraccount)
        {
            account_friends = useraccount.GetFriends(Account.StatusFilter.All, 200);
        }

        public void avatar_fetch()
        {
            foreach (User friend in account_friends)
            {
                this.friend_ids[account_friends.IndexOf(friend)] = friend.Profile.onlineId;
                this.avatar_urls[account_friends.IndexOf(friend)] = friend.Profile.avatarUrls[0].avatarUrl;
                file_downloader avatar_file = new file_downloader(friend.Profile.onlineId + ".png", friend.Profile.avatarUrls[0].avatarUrl);
            }
        }

        public void friends_data_fetch()
        {
            foreach (User friend in account_friends)
            {
                String[] friend_data = { friend.Profile.onlineId };/*, friend.Profile.languagesUsed[0], friend.Profile.plus.ToString(),
                    friend.Profile.friendsCount.ToString(), friend.Profile.aboutMe, friend.Profile.trophySummary.level.ToString(),
                    friend.Profile.trophySummary.progress.ToString(), friend.Profile.trophySummary.earnedTrophies.platinum.ToString(),
                    friend.Profile.trophySummary.earnedTrophies.gold.ToString(), friend.Profile.trophySummary.earnedTrophies.silver.ToString(),
                    friend.Profile.trophySummary.earnedTrophies.bronze.ToString()};*/

                this.friends_data[account_friends.IndexOf(friend)] = friend_data;
            }

            var stream = new MemoryStream();
            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream);
            var csv = new CsvWriter(writer);

            foreach (var item in this.friends_data)
            {
                csv.WriteRecord(item);
            }

        }
        
        }
}
