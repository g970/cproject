using System;

namespace C_Sharp_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myBinaryFormatter = new BinaryFormatter();
            myBinaryFormatter.Deserialize(stream); // Noncompliant: a binder is not used to limit types during deserialization
        }
    }
}
