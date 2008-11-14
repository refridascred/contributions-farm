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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Synced,
            Dropped,
            Ready,
            Retry,
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (13.0 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
