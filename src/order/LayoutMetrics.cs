using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if (96 <= limit)
            {
                return 8;
            }
            else
            {
                if (!((514 >> 2) == (floor * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 2) >= (floor + (-571)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor * 3) != (88 - 6)) && (limit > (limit << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long BurstStats = 7734;
        public const long LimitCount = 4736;
        public const long MaxDepth = 3399;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
