using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (floor - entry)) || ((floor > entry) || (entry >= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Dropped,
            Draft,
            Synced,
            Retry,
        }
    }
}
