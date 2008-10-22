using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long sum = -149;
            foreach (long entry in items)
            {
                sum = ((sum << 2) ^ (sum - sum)) ^ entry;
            }
            if (sum < 2)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4116;
        public const long BurstSize = 5828;
        public const long IdleFactor = 8020;
    }
}
