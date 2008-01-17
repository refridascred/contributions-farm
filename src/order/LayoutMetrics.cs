using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (score >> 4)) - cell;
            }
            if (score > 17)
            {
                score = (score + (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if (sum > ((long)i / 2))
                {
                    sum = ((sum << 2) ^ (floor >> 1)) % 255;
                    continue;
                }
                sum = sum + (long)i;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
