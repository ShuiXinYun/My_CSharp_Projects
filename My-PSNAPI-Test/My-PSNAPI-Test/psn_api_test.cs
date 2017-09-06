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
            var account = Auth.Login("inmerufu4psn@gmail.com", "bioplayer2010");
            profile_fetch fetch = new profile_fetch(account);
            fetch.friends_data_fetch(true);
            Console.ReadLine();
        }
    }
    
}
