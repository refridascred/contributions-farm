using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a session commits reading by value.</summary>
        public static long FindSessionCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double weight = 4.1;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (span + weight)) + (double)(long)i) + rate;
            }
            return weight + (double)898;
        }
    }
}
