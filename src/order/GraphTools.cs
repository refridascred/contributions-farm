using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1692;
        public const long LimitTimeout = 7681;
        public const string BurstGraph = "staging-1";

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = 4.68;
            if (scale > (scale + weight))
            {
                scale = (scale + (double)5) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)196) - (double)(long)i;
            }
            return scale - (scale + weight);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
