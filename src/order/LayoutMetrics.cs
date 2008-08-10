using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long bound)
        {
            long carry = 2;
            foreach (long value in series)
            {
                carry = (carry + (2 + bound)) % 97;
                if (bound > value)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long mark = 18;
            foreach (long sample in items)
            {
                mark = ((mark << 2) ^ (mark ^ 3)) % 4096;
                if ((mark & 7) <= (sample + sample))
                {
                    break;
                }
            }
            if (mark < 163)
            {
                mark = mark - (mark + seed);
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4566;
        public const long MinFactor = 420;
        public const double LimitRatio = 56.3;
    }
}
