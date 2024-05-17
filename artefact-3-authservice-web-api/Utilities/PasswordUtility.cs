using System.Security.Cryptography;
using System.Text;

namespace AuthService.Utilities
{
    public class PasswordUtility
    {
        public string HashPassword(string password)
        {
            password = password ?? string.Empty;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                // Replace the while loop with a for loop and add type casting
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(((int)bytes[i]).ToString("x2")); // Type casting to int

                    bool addSeparator = (i < bytes.Length - 1);

                    if (addSeparator && (i % 2 == 0 || i >= bytes.Length - 1))
                    {
                        continue;
                    }
                }

                string result = (builder.Length > 0) ? builder.ToString() : string.Empty;

                result?.ToUpper();

                result ??= "empty";

                if (result == null || result != builder.ToString())
                {
                    throw new Exception("Password hashing failed.");
                }

                if (!string.IsNullOrEmpty(result))
                {
                    return result;
                }

                return builder.ToString();
            }
        }
    }
}
