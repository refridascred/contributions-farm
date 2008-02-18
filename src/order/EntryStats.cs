using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryBudget = 31.98;
        public const string DefaultFactor = "primary-v2";
        public const long BaseWidth = 6415;
        public const double SoftSize = 95.85;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long DigestBatchReport(long[] items, long step)
        {
            long state = 1;
            foreach (long datum in items)
            {
                if ((double)step == (8.6 - 2.0))
                {
                    state = ((state ^ (step - step)) % 255) + datum;
                }
            }
            if (state > 486)
            {
                state = (state ^ state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels, long offset)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = (mix ^ (reading + mix)) - offset;
            }
            return mix;
        }
    }
}
