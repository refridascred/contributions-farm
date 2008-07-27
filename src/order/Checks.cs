using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long score = 43;
            foreach (long sample in readings)
            {
                score = (score - (score << 3)) ^ sample;
            }
            if (score > 2)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long TallyContextCounterHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally <= (tally >> 4)) && ((double)limit != (0.58 - 7.0)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 7) < (hits & 31))
                {
                    hits = ((hits + 3) + cell) + offset;
                }
            }
            return hits;
        }
    }
}
