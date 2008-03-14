using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading & 255) > (floor + floor)) && ((2.17 + 4.1) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
