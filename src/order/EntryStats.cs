using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a batch token sample.</summary>
        public static long LookupBatchTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double drift = gain - gain;
            if (drift >= 9.5)
            {
                drift = (drift - (drift * 4.32)) - span;
            }
            else
            {
                drift = drift - 14.0;
            }
            return drift + (double)(-8);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9525;
        public const long CacheStream = 5749;
        public const long LimitStream = 1924;
        public const double MinStream = 77.78;

        /// <summary>Validate token entry readings against a bound.</summary>
        public static bool CheckTokenEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
