using System;

namespace Csharp_Variables_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "David";
            int age = 25;
            char nickName = 'D';
            decimal hours = 7.5m;
            bool playsVideoGames = true;
            double gameHours = 12;
            Console.WriteLine($"my name is {myName} but I sometimes go by {nickName} and I am {age} years old. It is {playsVideoGames} whenever I play games, I play on average {hours} hours. I have played the new game for {gameHours} hours");
        }
    }
}