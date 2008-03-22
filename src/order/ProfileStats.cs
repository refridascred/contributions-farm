using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 2951;
        public const long DefaultAccount = 7302;
        public const double SoftRatio = 76.82;
        public const long HardTimeout = 9447;
        public const long RetryRatio = 412;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) <= (seen + (long)items.Length))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
