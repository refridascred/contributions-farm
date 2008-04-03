using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "stable-edge";
        public const long BatchInterval = 4277;
        public const double DefaultCount = 23.2;
        public const string SoftLevel = "primary";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((15.0 / 2.0) < (double)bound)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
