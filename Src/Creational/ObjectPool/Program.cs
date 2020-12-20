using ObjectPool.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<RandomNumbers> pool = new ObjectPool<RandomNumbers>(() => new RandomNumbers());
            
            RandomNumbers mc = pool.Get();
            Console.WriteLine("{0:####.####}", mc.GetValue(0));

            RandomNumbers mc2 = pool.Get();
            Console.WriteLine("{0:####.####}", mc2.GetValue(0));

            pool.Release(mc);

            RandomNumbers mc3 = pool.Get();
            Console.WriteLine("{0:####.####}", mc3.GetValue(0));

            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }
    }
}
