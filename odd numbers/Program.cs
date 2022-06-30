using System;
using static System.Console;


namespace odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for(int x = 5; x <= 500; x++)
            {
                if(x % 5 == 0)
                {
                    Write("{0,5}",x);   
                    counter++;
                    if(counter == 10)
                    {
                        Write("\n");
                        counter = 0;
                    }
                }
            }
            ReadKey();
        }
    }
}
