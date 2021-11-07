using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
           int chickenCount = chickens * 2;
           int cowsCount = cows * 4;
           int pigsCount = pigs * 4;
           return chickenCount + cowsCount + pigsCount;

        }
    }
}
