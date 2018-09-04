using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            int arrows = 5;
            int enemies = 5;
            int health = 5;
            Random Rand = new Random();
            bool TF = true;

            Console.WriteLine("press 'a' to shoot your bow");
            Console.WriteLine("press 'd' to dodge an enemy");
            
            while(arrows > 0)
            {   
                if(Console.ReadKey(true).KeyChar == 'a')
                {
                    TF = Rand.Next(2) == 0 ? false : true;
                    if(TF == true)
                    {
                        arrows--;
                        enemies--;
                        Console.WriteLine("You killed an enemy!");
                    }else {
                        arrows--;
                        Console.WriteLine("You have missed");
                    }
                }
                if(arrows <= 0)
                {
                    Console.WriteLine("You are out of arrows!");
                }
            
            if(enemies > 0)
            {   
                if(Console.ReadKey(true).KeyChar == 'd')
                {
                    TF = Rand.Next(2) == 0 ? false : true;
                    if(TF == true)
                    {
                        Console.WriteLine("You dodged an enemy!");
                    }else {
                        health--;
                        Console.WriteLine("You have been hit!");
                    }
                }
                if(health <= 0)
                {
                    Console.WriteLine("You are dead!");
                    Environment.Exit(0);
                }
    
            }
            }
            
        }
    }
}  