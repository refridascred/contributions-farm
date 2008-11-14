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

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 754;
        public const string WindowProfile = "cached-1";
        public const long MaxCount = 3366;
        public const string BurstCount = "staging-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 9160;
        public const long IdleBudget = 2771;
        public const long LimitScore = 8877;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
