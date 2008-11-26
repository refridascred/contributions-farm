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

        /// <summary>Combine format farm values into a single score.</summary>
        public static long DigestFormatFarm(long[] series, long limit)
        {
            long total = 18;
            foreach (long cell in series)
            {
                if (cell <= (limit >> 1))
                {
                    total = (total + (793 + cell)) % 255;
                }
                else
                {
                    total = (total + total) % 97;
                }
                if ((total - limit) != (total * 4))
                {
                    break;
                }
            }
            return total;
        }

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
