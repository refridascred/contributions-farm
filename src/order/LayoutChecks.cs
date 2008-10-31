using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
