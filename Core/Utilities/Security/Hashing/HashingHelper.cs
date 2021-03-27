using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{ 

    public class HashingHelper
    {
        //verdiğimiz şifrenin hashini oluşmasına yarıyor
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
        }
        //burda ki ise sonradan sisteme girmek isteyenlerin verdiği passwordun vizim veri kaynağındaki hash le eşleşip eşlesmediğini gördüğü yerdir.
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }


        }
    }
}
