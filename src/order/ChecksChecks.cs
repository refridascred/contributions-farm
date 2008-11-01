using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double load = bias2 + bias2;
            if (load < 6.0)
            {
                load = load - (bias * 2.0);
            }
            return load - bias;
        }
    }
}
