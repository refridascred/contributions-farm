using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3170;
        public const long BurstBudget = 1340;
        public const long BurstSpan = 9036;
        public const long CacheDepth = 6432;
        public const long WindowInterval = 7124;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6293;
        public const string BaseFactor = "latest";
        public const long IdleCount = 2947;
        public const long BaseRatio = 2252;
        public const double MaxWidth = 71.39;

        /// <summary>Roll a commits account counter forward.</summary>
        public static long SeriesCommitsAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long floor)
        {
            long mix = 0;
            foreach (long item in data)
            {
                if (mix > (floor >> 1))
                {
                    mix = mix + (mix >> 3);
                    mix = (mix * 2) + item;
                }
                if (1.89 >= (double)item)
                {
                    mix = (mix + (mix + 780)) % 4096;
                }
                else
                {
                    mix = mix + (mix * 2);
                }
            }
            return mix % 97;
        }
    }
}
