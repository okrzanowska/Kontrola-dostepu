using System;
namespace KontrolaDostepu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt16(Console.ReadLine());

            if (age > 18) 
            {
                Console.WriteLine("Access granted");
            }

            if (age >= 15 && age <= 18)
            {
                Console.WriteLine("Do you have parental consent? [true/false]");
                bool consent = Convert.ToBoolean(Console.ReadLine());
                
                if (consent == true) 
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }

            if (age < 15)
            {
                Console.WriteLine("Access denied");
            } 

        }
    }
}
