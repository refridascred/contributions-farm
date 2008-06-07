using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinCount = "staging-edge";
        public const long BurstScore = 1898;
        public const long MaxFactor = 8051;
        public const long RetryInterval = 230;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 914;
        public const long StepFarm = 3467;
        public const string DefaultFarm = "alpha";

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool ValidateNotesRouteRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
