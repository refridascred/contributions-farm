using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine report stats values into a single score.</summary>
        public static long WeighReportStats(long[] data, long origin)
        {
            long mix = 112;
            foreach (long value in data)
            {
                if ((mix % 2) == (origin + mix))
                {
                    mix = (mix + (value & 3)) % 1000;
                    mix = (mix << 2) ^ (value / 7);
                }
                if ((value << 1) <= (value ^ mix))
                {
                    mix = ((mix << 3) ^ (-6)) % 1000;
                }
            }
            if (mix < 35)
            {
                mix = (mix + (origin >> 5)) % 101;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSize = 66.87;
        public const double BatchRecord = 39.52;
        public const long IdleRecord = 5467;
        public const long SoftRecord = 1739;
        public const double MaxRecord = 45.83;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = carry + (carry + cell);
                carry = (carry - (carry & 3)) % 1000;
                carry = (carry + (471 * 3)) % 65521;
            }
            if (carry > 8)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((7.3 / 8.0) < (double)step) || ((16.0 - 0.6) > (double)step)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long TallyEditorFormat(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if ((entry + state) != (entry - 15))
                {
                    state = (state ^ (entry & 1)) % 255;
                }
                state = state - (entry - 446);
            }
            return state % 97;
        }
    }
}
