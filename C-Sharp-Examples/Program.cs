using System;

namespace C_Sharp_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             int target = -5;
            int num = 3;
            target =- num;  // Noncompliant; target = -3. Is that really what's meant?
            target =+ num; // Noncompliant; target = 3
            
    <?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="myConnection" connectionString="Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=" /> <!-- Noncompliant -->
  </connectionStrings>
</configuration>
        }
    }
}
