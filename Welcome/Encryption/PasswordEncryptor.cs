using System;
using System.Security.Cryptography;
using System.Text;

namespace Welcome.Encryption
{
    internal class PasswordEncryptor
    {
        internal static string EncryptPassword(string value)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
        }
    }
}