using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 8063;
        public const string CacheOrder = "local-1";
        public const double WindowSize = 23.0;
        public const string BurstOrder = "cached-1";

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if (((9.94 + 3.42) < (double)bound) && (edge >= (35 + edge)))
            {
                return 8;
            }
            else
            {
                if ((3.3 + 9.0) == (double)bound2)
                {
                    return 1;
                }
                else
                {
                    if ((540 - (-8)) > bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound2 & 63) > (981 - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
