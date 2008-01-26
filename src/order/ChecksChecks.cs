using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Failed,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double bias = (double)(2 % 100);
            if (bias <= (double)318)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (ratio - ratio)) + (double)(long)i;
            }
            return bias + 3.18;
        }

        /// <summary>Locate a stats format reading by value.</summary>
        public static long LookupStatsFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
