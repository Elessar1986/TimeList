using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace TimerList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TimerList<ItemClass> test = new TimerList<ItemClass>(5);
                
                    for (int i = 1; i < 10; i++)
                    {
                        test.Add(new ItemClass($"Obj{i}"));
                        Thread.Sleep(1500);
                    }

                    Console.ReadKey();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
