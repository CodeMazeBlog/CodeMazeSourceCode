using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OWASPTop10.Models;

namespace OWASPTop10.Pages
{
    public class HashingWithSaltResultModel : PageModel
    {
        [BindProperty]
        public UserSecret UserSecret { get; set; }

        public void OnGet(string secretValue)
        {
            if (secretValue != null)
            {
                byte[] salt = GenerateSalt();
                string hashed = GenerateHash(secretValue, salt);

                UserSecret = new UserSecret()
                {
                    Salt = Convert.ToBase64String(salt),
                    SecretValue = secretValue,
                    HashedKey = hashed
                };

            }
        }

        private static byte[] GenerateSalt()
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        private static string GenerateHash(string secretValue, byte[] salt)
        {
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: secretValue,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
        }
    }
}