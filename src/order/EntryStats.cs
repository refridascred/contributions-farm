using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 71.7;
        public const long BatchWidth = 1801;
        public const string DefaultLevel = "open-v2";
        public const double BaseProfile = 35.8;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 81.95;
        public const double CacheWidth = 71.79;
        public const string BurstReport = "alpha-edge";
        public const long MinBudget = 9466;
        public const long RetryDepth = 6285;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
