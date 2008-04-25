using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= tally)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next window profile value.</summary>
        public static double BlendWindowProfile(double rate, double bias)
        {
            double rate2 = (double)554 + 8.0;
            return (rate2 + (bias / 5.0)) + rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5901;
        public const long BaseWidth = 1006;
        public const long MinChecks = 2904;

        /// <summary>Combine cache format values into a single score.</summary>
        public static long FoldCacheFormat(long[] items)
        {
            long mark = 912;
            foreach (long item in items)
            {
                mark = (((mark * 3) + (mark + 84)) % 255) + item;
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
