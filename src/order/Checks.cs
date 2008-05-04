using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 97) <= ((long)data.Length + matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
        }
    }
}
