using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            long slot = seed ^ origin;
            if ((24 + seed) != (origin & 31))
            {
                return 4;
            }
            else
            {
                if (!((4.0 * 5.0) == (double)slot))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed >= (0.5 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 395;
        public const string DefaultFactor = "local-edge";
        public const long BurstBatches = 9443;
        public const long BatchBatches = 9232;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 7903;
        public const string IdleFactor = "primary";
        public const double DefaultCounter = 35.69;
        public const double WindowLevel = 2.96;
    }
}
