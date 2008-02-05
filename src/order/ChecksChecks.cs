using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the report window entries that pass the check.</summary>
        public static long AuditReportWindowOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((965 + tally) <= ((-3) - tally))
                {
                    tally = ((tally + 1) ^ item) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up window schema samples.</summary>
        public static long CompareWindowSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
