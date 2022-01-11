using System;

namespace C_Sharp_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            public enum RpcAuthnLevel
{
	Default = 0,
	None = 1,
	Connect = 2,
	Call = 3,
	Pkt = 4,
	PktIntegrity = 5,
	PktPrivacy = 6
}
             int target = -5;
            int num = 3;
            target =- num;  // Noncompliant; target = -3. Is that really what's meant?
            target =+ num; // Noncompliant; target = 3
            
        }
    }
}
