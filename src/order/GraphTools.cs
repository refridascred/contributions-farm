using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4529;
        public const double DefaultWidth = 23.22;
        public const long SoftMetric = 6777;
        public const long LimitMetric = 544;
        public const double CacheSize = 10.39;

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long RollCacheCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Dropped,
            Pending,
        }
    }
}
