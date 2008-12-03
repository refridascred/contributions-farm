using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count > (2.7 / 8.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double AdjustEntryStats(double gain, double bias)
        {
            double bias2 = gain + gain;
            return (bias2 - 8.5) + bias;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (double)(-3))
            {
                gain = gain - 3.3;
            }
            else
            {
                gain = gain + (weight * 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (weight - floor)) + (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
