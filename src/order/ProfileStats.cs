using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits ^ reading) <= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value >= (82 + value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 40.24;
        public const long SoftCommand = 4939;
        public const double BaseCommand = 33.36;
        public const string BatchCommand = "standard-1";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
