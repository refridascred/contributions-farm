using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metric buffer readings.</summary>
        public static long CombineMetricBuffer(long[] items)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = ((score << 3) ^ (9 + datum)) % 97;
            }
            if (score < 97)
            {
                score = score ^ (score / 5);
            }
            return score % 4096;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double weight = (floor - 19.0) - (floor * 9.81);
            if (weight > weight)
            {
                weight = weight + (floor / 5.0);
            }
            else
            {
                weight = weight - (3.5 * 4.8);
            }
            return weight + gain;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((mark % 60) <= datum)
                {
                    mark = (((mark * 2) + 1) % 1000) + target;
                }
                else
                {
                    mark = (mark - (822 / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long origin)
        {
            long sum = 64;
            foreach (long value in levels)
            {
                sum = ((sum + (40 % 16)) ^ value) - origin;
            }
            return sum % 4096;
        }
    }
}
