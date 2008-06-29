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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Queued,
            Pending,
            Done,
            Draft,
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
