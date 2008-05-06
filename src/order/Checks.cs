using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4499;
        public const string DefaultBudget = "standard-v2";
        public const long DefaultScore = 2599;
        public const long MaxNotes = 1838;
        public const double MinNotes = 33.62;

        /// <summary>Roll a cache entry counter forward.</summary>
        public static long SeriesCacheEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
