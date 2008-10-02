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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((floor * 3) >= hits)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
