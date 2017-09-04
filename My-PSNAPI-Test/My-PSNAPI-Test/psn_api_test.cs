using System;
using System.Collections.Generic;
using PSN;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace My_PSNAPI_Test
{
    [TestClass]
    public class psn_csharp_api_test
    {
        [TestMethod]
        public static void Main()
        {
            var account = Auth.Login("inmerufu4psn@gmail.com", "passwd");
            profile_fetch fetch = new profile_fetch(account);
            fetch.friends_data_fetch();
            //Console.WriteLine(fetch.friend_ids);
            Console.ReadLine();
            //List<User> account_friends = account.GetFriends("all");
            // Console.WriteLine(account_friends[0].Profile.onlineId);
            //Console.WriteLine(account_friends[0].Profile.trophySummary.progress);
            //Console.WriteLine(account_friends[0].CompareTrophies());
            //Console.WriteLine(account.Profile.aboutMe);
            //Console.WriteLine(account_friends[0].Profile.avatarUrls[0].avatarUrl);
            //Console.ReadLine();
            /*
            string account_id = account.Profile.onlineId;
            string account_lang= account.Profile.languagesUsed[0];
            int account_isplus = account.Profile.plus;
            string account_abountme = account.Profile.aboutMe;
            string account_avatar_url = account.Profile.avatarUrls[0].avatarUrl; //0为大头像
            string account_personal_detail = account.Profile.personalDetail.firstName + account.Profile.personalDetail.lastName;
            int account_frientscount = account.Profile.friendsCount;
            int[] account_trophy = { 0, 0, 0, 0, 0, 0 };//奖杯，等级、下一等级完成度、白金杯数、黄金杯数、白银杯数、铜杯数
            account_trophy[0] = account.Profile.trophySummary.level;
            account_trophy[1] = account.Profile.trophySummary.progress;
            account_trophy[2] = account.Profile.trophySummary.earnedTrophies.platinum;
            account_trophy[3] = account.Profile.trophySummary.earnedTrophies.gold;
            account_trophy[4] = account.Profile.trophySummary.earnedTrophies.silver;
            account_trophy[5] = account.Profile.trophySummary.earnedTrophies.bronze;
            System.Collections.Generic.List<User> account_friends = account.GetFriends("all", 200);
            Console.WriteLine("account id  "+account_id);
            Console.WriteLine("account language  " + account_lang);
            Console.WriteLine("account PLUS status  " + account_isplus);
            Console.WriteLine("account about me  " + account_abountme);
            Console.WriteLine("account avatar url  " + account_avatar_url);
            Console.WriteLine("account personal detail  "+ account_personal_detail);
            Console.WriteLine("account trophies: Level  " + account_trophy[0]+ "   Platinum Numbers  "+ account_trophy[2]);
            Console.WriteLine("account friends numbers  " + account_frientscount);
            foreach (User friend in account_friends)
            {
                Console.WriteLine("Friend ID: "+friend.Profile.onlineId + "   isOnline?: "+friend.Profile.primaryOnlineStatus);
            }
           // file_downloader avatar_file = new file_downloader("Avatar.png", account_avatar_url);
            Console.WriteLine();
            Console.ReadLine();
            */

        }
    }
    
}
