using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if ((step * 2) >= step)
            {
                return 5;
            }
            else
            {
                if ((step2 - step) <= (step2 << 3))
                {
                    return 7;
                }
                else
                {
                    if (step2 < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 3605;
        public const long LimitBudget = 3033;
        public const long IdleSpan = 3208;
        public const double MaxSize = 55.56;
        public const double BatchCommits = 30.37;
    }
}
