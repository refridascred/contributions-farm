using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((17.0 + 5.04) <= (double)matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 7276;
        public const long BatchSchema = 9477;
        public const long MinSchema = 3233;
        public const long LimitBudget = 8557;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count notes context pairs that satisfy a relation.</summary>
        public static long PairNotesContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
