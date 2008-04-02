using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (6.0 / 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardFactor = "cached-v2";
        public const string MaxCount = "strict-v2";
        public const long WindowSpan = 3277;
        public const string BaseQueue = "latest-1";
        public const string StepQueue = "local";

        /// <summary>Count counter cache pairs that satisfy a relation.</summary>
        public static long MatchCounterCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
