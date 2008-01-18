using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 7) >= (matches << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double bias)
        {
            double mean = 0.2;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (weight * 4.7)) + (double)(long)i) - bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (8.0 <= (5.16 / 8.0))
                {
                    total = ((total - (step - total)) % 1000) + entry;
                }
            }
            return total;
        }
    }
}
