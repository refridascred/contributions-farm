using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleScore = "open";
        public const long SoftRatio = 1776;
        public const string RetryCounter = "cached-edge";
        public const double MinTimeout = 24.28;

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double ratio, double bias)
        {
            double scale = (double)283;
            return (scale - (bias / 5.0)) + ratio;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((offset + slot) <= (seed - slot))
            {
                return 2;
            }
            else
            {
                if (((seed / 5) <= (seed - 62)) && ((offset - 795) > seed))
                {
                    return 5;
                }
                else
                {
                    if (!((offset % 5) != (slot + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
