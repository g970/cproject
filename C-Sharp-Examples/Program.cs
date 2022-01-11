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
            
            
     public class FooBarController : Controller
{
    [HttpPost] // Noncompliant
    [ValidateInput(false)]
    public ActionResult Purchase(string input)
    {
        return Foo(input);
    }

    [HttpPost] // Noncompliant
    public ActionResult PurchaseSomethingElse(string input)
    {
        return Foo(input);
    }
}
        }
    }
}
