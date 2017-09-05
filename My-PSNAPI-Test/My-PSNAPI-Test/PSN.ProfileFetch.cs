using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSN;
using CsvHelper;


namespace My_PSNAPI_Test
{

    public class profile_fetch
    {
        public List<string> friend_ids { get; set; }
        public List<string> avatar_urls { get; set; }
        public List<User> account_friends { get; set; }
        public List<List<string>> friends_data = new List<List<string>>();

        public profile_fetch(Account useraccount)
        {
            account_friends = useraccount.GetFriends("all", useraccount.Profile.friendsCount);
        }

        public void friends_data_fetch(Boolean avatar_fetch=false)
        {
            foreach (User item in account_friends)
            {
                //Account.GetFriends()获取的信息不完整, 故再创建User 对象
                User friend = new User(item.Profile.onlineId);
                List<string> friend_data= new List<string>();
                friend_data.Add(friend.Profile.onlineId);
                friend_data.Add(friend.Profile.plus.ToString());

                ///////////////////////////////////////////////////////////////////////
                //拉取用户信息
                //若返回值为null载使用toString()方法会报错未将对象引用设置到对象的实例
                try
                {
                    friend_data.Add(friend.Profile.languagesUsed[0]);
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.friendsCount.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.aboutMe);
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.level.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.progress.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.earnedTrophies.platinum.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.earnedTrophies.gold.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.earnedTrophies.silver.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                try
                {
                    friend_data.Add(friend.Profile.trophySummary.earnedTrophies.bronze.ToString());
                }
                catch (Exception)
                {
                    friend_data.Add("--");
                }

                friend_data.Add(friend.Profile.avatarUrls[0].avatarUrl);

                Console.WriteLine(friend.Profile.onlineId+ "  data fetched");
                this.friends_data.Add(friend_data);

                ///////////////////////////////////////////////////////////////////////
                //更新头像数据
                if (avatar_fetch)
                {
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "/avatars/"))
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/avatars/");
                    }
                    file_downloader avatar_file = new file_downloader(Directory.GetCurrentDirectory() + "/avatars/" + friend.Profile.onlineId + ".png", friend.Profile.avatarUrls[0].avatarUrl);
                }

                ///////////////////////////////////////////////////////////////////////
            }
            ///////////////////////////////////////////////////////////////////////

            //var sr = new StreamReader(@"DataBase.csv");
            if (!Directory.Exists(@System.Environment.CurrentDirectory + "/data"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/data");
            }
            StreamWriter sw = new StreamWriter(@Directory.GetCurrentDirectory() + "/data/DataBase.csv",true,Encoding.Default);
            CsvWriter writer = new CsvWriter(sw);
            foreach (List<string> item in this.friends_data)
            {
                for (int i = 0; i < this.friends_data[0].Count; i++)
                {
                    writer.WriteField(item[i]);
                }

                writer.NextRecord();
            }
            sw.Close();

        }

    }
}
