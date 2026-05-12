using System;
using System.Text;

namespace SecureKeyVault
{
    public static class SecurityHelper
    {
        // Password ko encrypt karne ke liye
        public static string EncryptBase64(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return "";
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        // Base64 ko wapas normal text banane ke liye
        public static string DecryptBase64(string base64EncodedData)
        {
            if (string.IsNullOrEmpty(base64EncodedData)) return "";
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}