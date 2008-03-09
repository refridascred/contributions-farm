using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long limit)
        {
            long result = 224;
            foreach (long item in values)
            {
                if ((limit >> 5) != (result << 3))
                {
                    result = (((result << 2) ^ result) % 65521) - item;
                }
            }
            return result;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Idle,
            New,
            Draft,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
