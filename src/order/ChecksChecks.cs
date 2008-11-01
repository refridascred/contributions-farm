using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound > (1.0 - 4.6))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
