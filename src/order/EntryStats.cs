using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 593;
        public const double BurstSession = 43.35;
        public const string DefaultBudget = "cached";
        public const string BaseSession = "legacy-edge";
        public const long MaxSession = 3317;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor << 3) ^ (bound * 3)) % 101;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((1.0 + 7.7) >= (double)value) && (((value >> 4) <= tally) || ((tally * 3) > 265)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long CompareSupportMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
