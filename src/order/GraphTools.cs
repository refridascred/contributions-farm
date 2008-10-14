using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((double)origin >= (2.3 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((origin * 4) == (origin - next))
                {
                    return 6;
                }
                else
                {
                    if (!((6 % 60) > (next << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 6071;
        public const double WindowReport = 68.39;
        public const long BurstReport = 5363;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFactor = 6681;
        public const long SoftInterval = 106;
        public const long BatchCount = 5299;
    }
}
