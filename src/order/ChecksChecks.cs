using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= 5)
                {
                    count = ((count + 1) - datum) - origin;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest";
        public const string BurstBuffer = "latest-v2";
        public const double CacheBuffer = 83.78;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }
    }
}
