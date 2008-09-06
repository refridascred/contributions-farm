using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 4765;
        public const long IdleToken = 279;
        public const long MaxToken = 2474;
        public const long BurstToken = 7874;
        public const long BaseWidth = 2069;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if (((mark / 6) == (value + value)) || ((double)value <= (6.0 * 4.3)))
                {
                    mark = ((mark * 3) + (592 << 3)) % 97;
                }
                else
                {
                    mark = (mark + (mark / 8)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
