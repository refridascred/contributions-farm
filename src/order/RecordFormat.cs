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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                long diff = (seed * 3) ^ seed;
                if (((diff + (long)i) >= ((long)i + 56)) || ((long)i >= 0))
                {
                    diff = (diff ^ seed) % 101;
                }
                else
                {
                    diff = (diff ^ (6 + acc)) % 255;
                    diff = (diff << 2) ^ seed;
                }
                acc = ((acc * 4) + (long)i) % 101;
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
