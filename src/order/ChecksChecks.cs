using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double span)
        {
            double rate = span;
            if (rate <= (rate / 4.0))
            {
                rate = rate - (span + ratio);
            }
            else
            {
                rate = rate - (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Draft,
            Closed,
            Retry,
            Done,
        }
    }
}
