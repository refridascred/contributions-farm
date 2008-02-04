using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 7419;
        public const long RetryProfile = 1909;
        public const long BurstSize = 5706;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
