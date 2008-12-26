using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a farm cache counter forward.</summary>
        public static long StepFarmCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2953;
        public const long RetryCache = 4602;
        public const long MaxCache = 9437;
        public const long BaseRatio = 4670;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
