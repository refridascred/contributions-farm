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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading << 2) != (reading + seen)) || ((seen & 3) == (seen & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
