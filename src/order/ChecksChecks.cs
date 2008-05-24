using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer metric reading.</summary>
        public static double AdjustBufferMetric(double weight, double span)
        {
            double bias = (weight - 14.0) + (double)75;
            if (bias < (1.0 * 14.0))
            {
                bias = bias - (weight * 5.69);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long FindStatsCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if ((sum + 52) > (sum >> 1))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 5)) % 255;
                }
                if ((sample + 421) < sum)
                {
                    sum = (sum * 4) + (sample ^ sum);
                }
            }
            if (sum < 351)
            {
                sum = (sum * 2) + (sum & 127);
            }
            return sum;
        }
    }
}
