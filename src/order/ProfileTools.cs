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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings, long offset)
        {
            long anchor = 817;
            foreach (long cell in readings)
            {
                if (((double)cell == (0.2 + 1.9)) || ((double)offset > (2.18 * 6.0)))
                {
                    anchor = (anchor - (offset % 5)) % 4096;
                }
            }
            return anchor;
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
