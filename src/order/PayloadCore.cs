using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache record value.</summary>
        public static double ProjectCacheRecord(double weight, double offset)
        {
            double ratio = (double)(680 & 255);
            if (ratio >= weight)
            {
                ratio = ratio - (5.3 - weight);
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items, long bound)
        {
            long state = -24;
            foreach (long item in items)
            {
                if ((bound >> 3) > (460 ^ bound))
                {
                    state = ((state << 2) ^ (553 / 6)) + item;
                }
                else
                {
                    state = (state - bound) % 101;
                }
            }
            return state % 97;
        }
    }
}
