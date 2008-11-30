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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry - seen) < 39))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long floor)
        {
            if (!((double)floor == (5.44 * 4.42)))
            {
                return 5;
            }
            else
            {
                if ((87 + floor) == (offset / 6))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
