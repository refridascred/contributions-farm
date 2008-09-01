using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3563;
        public const double MaxContributi = 69.29;
        public const string HardContributi = "legacy";

        /// <summary>Digest a series of token cache entries.</summary>
        public static long WeighTokenCache(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if (((item % 3) <= anchor) && (item <= (item * 2)))
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) >= bound)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
