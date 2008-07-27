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

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
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
