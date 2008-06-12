using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 8249;
        public const string DefaultScore = "latest-1";
        public const long BaseStats = 5836;
        public const string WindowStats = "strict-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((target << 2) < target) && ((hits + target) == (hits + reading))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (6 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
