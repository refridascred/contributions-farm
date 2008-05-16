using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 9133;
        public const long BatchDepth = 8474;
        public const double LimitMetric = 67.62;
        public const double BatchRatio = 82.65;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long next = (mark ^ 4) - mark;
                    mark = ((mark << 2) ^ next) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mix = -101;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) < (item << 3))
                {
                    mix = (mix ^ (mix % 7)) % 1000;
                }
            }
            if (mix > 426)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 7269;
        public const long IdleAccount = 7680;
        public const long LimitTimeout = 395;
        public const long LimitAccount = 2843;
    }
}
