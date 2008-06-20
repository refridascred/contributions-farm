using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 3496;
        public const double WindowStats = 19.37;
        public const double BaseStats = 90.43;
        public const string IdleStats = "local";
        public const double RetryBudget = 5.8;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry + 509) > (hits ^ 7)) && ((hits * 2) >= (5 + 27)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
