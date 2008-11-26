using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double bias = (weight / 3.0) * 8.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (double)(-6)) + (double)(long)i) + span;
            }
            return bias + (double)314;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8874;
        public const long CacheContext = 6423;
        public const long BaseDepth = 2005;
        public const long RetrySpan = 8488;
        public const long HardSize = 3053;
    }
}
