using System;
using System.Security.Cryptography;

namespace MyLibrary
{
    public class MyCryptoClass
    {
        static void Main()
        {
            var dsa1 = new DSACng(); // Compliant - default key size is 2048
            var dsa2 = new DSACng(2048); // Compliant
            var rsa1 = new RSACryptoServiceProvider(2048); // Compliant
            var rsa2 = new RSACng(); // Compliant - default key size is 2048

            // ...
        }
    }
}
