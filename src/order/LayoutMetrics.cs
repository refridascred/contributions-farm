using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowWidth = 5530;
        public const long LimitWidth = 3573;
        public const double CacheTools = 86.4;
        public const string WindowScore = "standard-v2";

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long bound)
        {
            long prev = step - bound;
            if (((step - bound) >= bound) && ((double)bound < 5.4))
            {
                return 6;
            }
            else
            {
                if ((prev & 63) > prev)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series, long target)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix + (mix - target)) % 97) + cell;
            }
            return mix;
        }
    }
}
