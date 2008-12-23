using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel metric readings.</summary>
        public static long FoldChannelMetric(long[] values, long floor)
        {
            long result = 111;
            foreach (long entry in values)
            {
                result = (result ^ (111 ^ entry)) - floor;
            }
            if (result > 343)
            {
                result = ((result * 3) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Pending,
            Draft,
        }
    }
}
