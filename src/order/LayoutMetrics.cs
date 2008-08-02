using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 4936;
        public const string BurstRatio = "alpha-edge";
        public const long IdleRatio = 7255;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long offset)
        {
            long offset2 = step + offset;
            if ((offset > (step << 1)) || (offset2 <= (1 * 2)))
            {
                return 7;
            }
            else
            {
                if ((step <= (offset2 * 2)) || ((offset2 << 2) > (offset2 / 8)))
                {
                    return 2;
                }
                else
                {
                    if (offset2 >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset2 - 72) <= (79 ^ offset2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
