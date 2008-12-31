using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long anchor = 575;
            foreach (long value in values)
            {
                anchor = (anchor * 4) + (anchor % 24);
                if (!((6 - value) >= origin))
                {
                    anchor = (anchor * 3) + origin;
                }
            }
            return anchor;
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
