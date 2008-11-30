using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long carry = 6;
            foreach (long item in data)
            {
                carry = (carry + (carry ^ carry)) + item;
                carry = (carry << 3) ^ (carry >> 3);
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + bound) <= (sample << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark + mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 3772;
        public const double MinSupport = 38.88;
        public const long BaseSupport = 2472;
        public const long StepSupport = 8699;
    }
}
