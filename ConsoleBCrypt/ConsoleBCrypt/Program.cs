using DevOne.Security.Cryptography.BCrypt;
using System;

namespace ConsoleBCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BCrypt对密码进行加密及密码验证
            // Console.WriteLine("BCryptHelper");
            // string salt = BCryptHelper.GenerateSalt();
            // Console.WriteLine($"产生随机盐 salt:{salt}");

            // string password = "1234567890";
            //Console.WriteLine($"明文:{password}");
            // string pwd = BCryptHelper.HashPassword(password, salt);
            // Console.WriteLine($"加密以后的密文:{pwd}");
            // bool isMatchpasswordAndpwd = BCryptHelper.CheckPassword("1234567890", pwd);
            // Console.WriteLine($"明文和加密以后的密文是否匹配:{isMatchpasswordAndpwd}"); 
            #endregion


            Console.WriteLine("BCryptHelper");
            string salt = BCrypt.Net.BCrypt.GenerateSalt(28);
            Console.WriteLine($"产生随机盐 salt:{salt}");
            salt = BCrypt.Net.BCrypt.GenerateSalt();
            Console.WriteLine($"产生随机盐 salt:{salt}");
            string password = "1234567890";
            Console.WriteLine($"明文:{password}");
            string pwd = BCrypt.Net.BCrypt.HashPassword(password);
            Console.WriteLine($"加密以后的密文:{pwd}");
            pwd = BCrypt.Net.BCrypt.HashPassword(password,4);
            Console.WriteLine($"加密以后的密文:{pwd}");
            pwd = BCrypt.Net.BCrypt.HashPassword(password, salt);
            Console.WriteLine($"加密以后的密文:{pwd}");
            pwd = BCrypt.Net.BCrypt.HashString("密文");
            Console.WriteLine($"加密以后的密文:{pwd}");
            pwd = BCrypt.Net.BCrypt.HashString("密文",4);
            Console.WriteLine($"加密以后的密文:{pwd}");
           bool isMatchpasswordAndpwd = BCrypt.Net.BCrypt.Verify("密文", pwd);
            Console.WriteLine($"明文和加密以后的密文是否匹配:{isMatchpasswordAndpwd}");

            //string salt = BCrypt.Net.BCrypt.GenerateSalt
            //Console.WriteLine($"产生随机盐 salt:{salt}");

            //string password = "1234567890";
            //Console.WriteLine($"明文:{password}");
            //string pwd = BCryptHelper.HashPassword(password, salt);
            //Console.WriteLine($"加密以后的密文:{pwd}");
            //bool isMatchpasswordAndpwd = BCryptHelper.CheckPassword("1234567890", pwd);
            //Console.WriteLine($"明文和加密以后的密文是否匹配:{isMatchpasswordAndpwd}");
            Console.ReadLine();
        }
    }
}
