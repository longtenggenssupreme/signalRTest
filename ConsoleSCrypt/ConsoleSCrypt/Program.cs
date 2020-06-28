using CryptSharp.Utility;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleSCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SCrypt对密码进行加密及密码验证
            // //using CryptSharp.Utility; 使用SCrypt的加密算法
            //Console.WriteLine("SCrypt");
            //string pwd = "SCrypt明文信息";
            ////HashAlgorithm hash = HashAlgorithm.Create("MD5");
            //HashAlgorithm hash = MD5.Create();
            //byte[] ms5bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            //Console.WriteLine($"ms5bytes :{BitConverter.ToString(ms5bytes).Replace("-",string.Empty)}");
            //byte[] salt = new byte[10];
            //byte[] salt2 = new byte[4];
            //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            //rng.GetBytes(salt);
            //rng.GetBytes(salt2);
            //Console.WriteLine(BitConverter.ToString(salt2));
            //byte[] result = SCrypt.ComputeDerivedKey(Encoding.UTF8.GetBytes(pwd), salt, 4, 8, 2, 2, 5);
            //Console.WriteLine($"加密以后的密文:{BitConverter.ToString(result).Replace("-","").ToLower()}");

            #endregion

            #region SCrypt.Net.SCrypt

            Console.WriteLine("SCrypt.Net.BCrypt");
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
