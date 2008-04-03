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

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long total = 39;
            foreach (long sample in data)
            {
                if ((total + step) > (sample - (long)data.Length))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
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
