using System;

namespace InClassproject
{
    class leave
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("How many days do you want to take of work");
                int days = int.Parse(Console.ReadLine());
                if (days > 7)
                {
                    Console.WriteLine("Sorry your leave is denied !");
                }
                else
                {
                   if (days >= 0 & days <= 7)
                    {
                        Console.WriteLine("you can leave");
                    }
                }

            }
            catch
            {
                Console.WriteLine("There is an ERROR IN THE CODE!");
            }
        }
    }
}
