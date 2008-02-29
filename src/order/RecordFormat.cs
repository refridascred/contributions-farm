using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = ratio;
            if (mean >= floor)
            {
                mean = mean - floor;
            }
            return mean - (double)242;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a context metric reading by value.</summary>
        public static long LocateContextMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
