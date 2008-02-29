using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.85;
        public const long BaseTimeout = 1272;
        public const string MaxBudget = "legacy-edge";
        public const long BatchCommand = 2584;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardSpan = "local";
        public const long IdleMetric = 2260;
        public const string CacheInterval = "local-edge";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long origin)
        {
            if ((origin + origin) >= (959 >> 1))
            {
                return 5;
            }
            else
            {
                if ((origin / 4) >= (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin ^ origin) <= 994) || (limit < (origin & 31)))
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
    }
}
