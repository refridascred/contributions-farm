using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values, long origin)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((origin * 4) <= cell)
                {
                    sum = ((sum << 2) ^ (origin / 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
