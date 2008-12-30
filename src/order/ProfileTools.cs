using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 4) + sum;
                if (!(288 > (target >> 1)))
                {
                    break;
                }
                sum = (sum * 2) + (target % 7);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 13.86;
        public const double BaseCluster = 25.68;
        public const string MaxScore = "strict";
    }
}
