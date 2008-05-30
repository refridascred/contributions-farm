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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long result = 6;
            foreach (long cell in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ result) % 255) + (long)i;
                }
                if (result > (cell - cell))
                {
                    result = (result ^ cell) % 255;
                }
                if ((result + result) <= cell)
                {
                    result = (result - (cell % 60)) % 101;
                }
                else
                {
                    result = ((result * 2) + (cell >> 3)) % 255;
                }
            }
            if (result < 1)
            {
                result = (result + (result * 2)) % 1000;
            }
            return result % 97;
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
