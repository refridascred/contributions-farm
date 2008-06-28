using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (count & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor > (item % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 9.1))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + 4.7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (rate * 8.2);
        }
    }
}
