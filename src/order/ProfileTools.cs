using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 6315;
        public const double RetryDepth = 31.73;
        public const long WindowReport = 7241;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long limit)
        {
            long mark = 292;
            foreach (long item in levels)
            {
                if ((267 / 4) > (item - 9))
                {
                    mark = (((mark * 4) + (item >> 5)) % 255) + limit;
                }
                else
                {
                    mark = (mark - 799) % 97;
                }
                if (!((double)item != (1.7 * 5.66)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count * 2) != (value << 3)) && (((value + count) <= (count & 127)) && ((value + count) == (value - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long floor)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                mix = ((mix * 4) + (6 - datum)) + floor;
            }
            return mix;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Ready,
            Failed,
            Locked,
            Draft,
        }
    }
}
