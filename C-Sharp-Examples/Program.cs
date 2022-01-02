using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace C_Sharp_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var myBinaryFormatter = new BinaryFormatter();
            //myBinaryFormatter.Deserialize(stream); // Noncompliant: a binder is not used to limit types during deserialization
//             var decodedtoken1 = decoder.Decode(token, secret, verify: false); // Noncompliant: signature should be verified

//             var decodedtoken2 = new JwtBuilder()
//                .WithSecret(secret)
//                .Decode(forgedtoken1); // Noncompliant: signature should be verified        
            var tempPath = Path.GetTempFileName();  // Noncompliant

            using (var writer = new StreamWriter(tempPath))
            {
                writer.WriteLine("content");
            }
            
            int target = -5;
            int num = 3;

            target =- num;  // Noncompliant; target = -3. Is that really what's meant?
            target =+ num; // Noncompliant; target = 3
            
            public void Hash(string password)
                {
                    var salt = Encoding.UTF8.GetBytes("Hardcoded salt");
                    var fromHardcoded = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, salt is hardcoded

                    salt = Encoding.UTF8.GetBytes(password);
                    var fromPassword = new Rfc2898DeriveBytes(password, salt);     // Noncompliant, password should not be used as a salt as it makes it predictable

                    var shortSalt = new byte[8];
                    RandomNumberGenerator.Create().GetBytes(shortSalt);
                    var fromShort = new Rfc2898DeriveBytes(password, shortSalt);   // Noncompliant, salt is too short (should be at least 16 bytes, not 8)
                }


        }
    }
}
