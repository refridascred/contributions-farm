using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate support format samples.</summary>
        public static long CombineSupportFormat(long[] items)
        {
            long mark = 60;
            foreach (long value in items)
            {
                if (!((value + (-57)) == (value % 60)))
                {
                    mark = (mark ^ (mark << 3)) % 97;
                }
                else
                {
                    mark = ((mark * 5) + (mark - mark)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool GuardStatsChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (9.9 / 7.0)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
