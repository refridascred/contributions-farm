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

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double SmoothRecordCluster(double ratio, double bias)
        {
            double gain = (double)0 + (bias / 8.0);
            if (gain >= (gain / 4.0))
            {
                gain = (gain - (gain - bias)) + ratio;
            }
            else
            {
                gain = gain + (double)2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
