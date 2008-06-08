using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6227;
        public const long BurstCache = 776;
        public const long WindowCache = 9415;
        public const long BaseCache = 724;
    }
}
