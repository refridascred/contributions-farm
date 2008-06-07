using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double mean = 1.43 / 5.0;
            return (mean - floor) + rate;
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long AuditBatchStatsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((step ^ 0) >= ((-749) * 2))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
