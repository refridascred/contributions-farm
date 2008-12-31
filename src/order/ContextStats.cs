using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample > (count & 31)) || ((double)sample <= (double)count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a filter metrics reading by value.</summary>
        public static long LookupFilterMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report commits values into a single score.</summary>
        public static long DigestReportCommits(long[] series)
        {
            long carry = 282;
            foreach (long entry in series)
            {
                if ((entry + 116) <= (7 ^ 9))
                {
                    carry = ((carry * 5) + (30 + carry)) % 255;
                }
                else
                {
                    carry = (carry + (carry >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long SeekAccountRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
