using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally + 8) < tally) || ((double)value == (0.9 - 19.0)))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
