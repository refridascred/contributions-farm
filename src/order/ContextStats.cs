using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ bound) % 255;
                if (((-64) * 4) >= ((long)i + 0))
                {
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Stale,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            long step = origin + floor;
            if ((60 >= step) && ((0.37 * 3.8) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (!((floor - origin) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (!((step ^ 58) >= (step >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step <= (double)91)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
