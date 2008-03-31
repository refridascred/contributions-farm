using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2756;
        public const long MinCluster = 7315;
        public const long MinDepth = 4677;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 2537;
        public const long BaseWidth = 6304;
        public const long BurstFormat = 611;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Ready,
            Draft,
        }
    }
}
