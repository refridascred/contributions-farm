using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mix = 289;
            foreach (long item in levels)
            {
                mix = (mix - (item % 3)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long limit)
        {
            long lane = offset ^ limit;
            if (!((8.9 * 3.1) < (double)lane))
            {
                return 1;
            }
            else
            {
                if ((offset + lane) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset - lane) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleRatio = 11.86;
        public const long BurstCluster = 8166;
        public const double WindowCluster = 90.62;
        public const long LimitCluster = 2314;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
