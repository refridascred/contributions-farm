using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if ((offset / 9) == (offset - bound))
            {
                return 0;
            }
            else
            {
                if (offset > (bound << 1))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + bound) == (offset / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 5889;
        public const long MaxCounter = 2513;
        public const double BurstTimeout = 50.21;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
