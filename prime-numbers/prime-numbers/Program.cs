using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            List<int> PrimeNum = new List<int>() { 1, 2, 3 };
            bool isPrime = true;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            //input
            for (int i = 4; i < 100000; i++) //looping through values
            {
                for (int j = 1; j < PrimeNum.Count; j ++) //checking to see if they are divisible
                {
                    int itemNum = PrimeNum[j];
                    if (i % itemNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //output

                if (isPrime)
                {
                    PrimeNum.Add(i);             
                }
                isPrime = true;

            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            foreach (var Value in PrimeNum)
            {     
                    Console.WriteLine(Value.ToString());
            }
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("Total Elapsed Time " + elapsedTime + " Total Prime values " + PrimeNum.Count);
            Console.Read();
        }
        

    }
}
