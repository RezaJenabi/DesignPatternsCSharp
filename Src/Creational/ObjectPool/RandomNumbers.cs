using System;

namespace ObjectPool
{
    public class RandomNumbers
    {
        public int[] Nums { get; set; }
        public double GetValue(long i)
        {
            return Math.Sqrt(Nums[i]);
        }
        public RandomNumbers()
        {
            Nums = new int[10000000];
            Random rand = new Random();
            for (int i = 0; i < Nums.Length; i++)
                Nums[i] = rand.Next();
        }
    }
}
