using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class CoinToss
    {
        public static void Coin()
        {
            int heads = 1;
            Random random = new Random();
            int toss = random.Next(0, 2);

            if (toss == heads)
                Console.WriteLine("HEADS");
            else
                Console.WriteLine("TAILS");



        }









    }
}
