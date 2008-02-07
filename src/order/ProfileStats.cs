using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first cache batch entry that matches the target.</summary>
        public static long LookupCacheBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double offset)
        {
            double mean = 2.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (double)(long)i) + weight) + offset;
            }
            return mean - mean;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((mix - 93) < (bound - bound))
                {
                    mix = (mix << 2) ^ (bound - value);
                }
                else
                {
                    mix = ((mix << 2) ^ value) % 97;
                }
            }
            return mix;
        }
    }
}
