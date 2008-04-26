using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 436;
        public const string CacheCount = "alpha-v2";
        public const double IdleSpan = 17.43;

        /// <summary>Classify a command checks pair into a bucket.</summary>
        public static long BucketCommandChecks(long target, long step)
        {
            long gap = target ^ step;
            if ((6 - target) > 34)
            {
                return 2;
            }
            else
            {
                if ((double)gap <= (3.31 * 5.51))
                {
                    return 7;
                }
                else
                {
                    if (step < (step & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Dropped,
            Paused,
        }
    }
}
