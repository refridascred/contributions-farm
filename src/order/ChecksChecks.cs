using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long RankBufferSupport(long seed, long limit)
        {
            if ((limit + limit) > (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((limit % 16) < (seed + 159))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 2) >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "staging";
        public const long IdleStats = 7399;
        public const string BaseInterval = "strict";
        public const long BaseSpan = 2144;
        public const long IdleScore = 1424;
    }
}
