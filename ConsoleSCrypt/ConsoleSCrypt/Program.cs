using CryptSharp.Utility;
using System;
using System.Security.Cryptography;

namespace ConsoleSCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SCrypt.Net.SCrypt

            Console.WriteLine("SCrypt.Net");
            Scrypt.ScryptEncoder scrypt = new Scrypt.ScryptEncoder();
            Scrypt.ScryptEncoder scrypt1 = new Scrypt.ScryptEncoder(4, 8, 1);
            Scrypt.ScryptEncoder scrypt2 = new Scrypt.ScryptEncoder(8, 16, 1, RandomNumberGenerator.Create());

            string pwd = "SCrypt明文信息";
            Console.WriteLine($"明文信息:{pwd}");
            string result = scrypt.Encode(pwd);
            Console.WriteLine($"加密以后的密文:{result}");

            //string pwd1 = "SCrypt明文信息111";
            //Console.WriteLine($"明文信息:{pwd1}");
            //string result1 = scrypt1.Encode(pwd1);
            //Console.WriteLine($"加密以后的密文:{result1}");

            //string pwd2 = "SCrypt明文信息222";
            //Console.WriteLine($"明文信息:{pwd2}");
            //string result2 = scrypt2.Encode(pwd2);
            //Console.WriteLine($"加密以后的密文:{result2}");

            bool isValid = scrypt.IsValid(result);
            Console.WriteLine($"加密以后的密文 isvalid:{isValid}");
            bool isMatchpasswordAndpwd= scrypt.Compare("SCrypt明文信息", result);
            Console.WriteLine($"明文信息与加密以后的密文是否一致:{isMatchpasswordAndpwd}");
            #endregion

            Console.ReadLine();
        }
    }
}
