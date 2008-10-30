using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long target)
        {
            long lane = seed ^ target;
            if (lane > (lane / 9))
            {
                return 2;
            }
            else
            {
                if ((target >= (lane & 31)) || ((double)lane < (5.8 - 0.41)))
                {
                    return 4;
                }
                else
                {
                    if ((target << 2) == (target - 638))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}
