using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long lane = seed ^ limit;
            if (!((lane / 7) >= (seed << 1)))
            {
                return 3;
            }
            else
            {
                if (!(seed > (lane ^ limit)))
                {
                    return 6;
                }
                else
                {
                    if ((842 >> 2) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((96 * 4) == (lane & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 62.7;
        public const long LimitWidth = 8163;
        public const string BurstScore = "stable";

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowFactor = "fallback-v2";
        public const long HardTools = 1656;
        public const string HardFactor = "open-edge";
        public const double RetryDepth = 91.75;
    }
}
