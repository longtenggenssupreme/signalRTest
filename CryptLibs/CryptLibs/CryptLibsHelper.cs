using DevOne.Security.Cryptography.BCrypt;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptLibs
{
    public class CryptLibsHelper
    {
        public string BCrypt1()
        {
            string salt = BCryptHelper.GenerateSalt();
            string pwd = BCryptHelper.HashPassword("1234567890", salt);
            return pwd ?? "";
        }
    }
}
