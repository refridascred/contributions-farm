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

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
