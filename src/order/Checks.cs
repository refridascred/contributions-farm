using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 63;
            foreach (long sample in values)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3707;
        public const string LimitWidth = "staging-v2";
        public const string WindowLevel = "staging-1";
        public const long DefaultAccount = 1669;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6509;
        public const string LimitCount = "local";
        public const long SoftCount = 2705;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Retry,
            New,
            Draft,
        }
    }
}
