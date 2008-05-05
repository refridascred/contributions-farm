using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Count the record commits entries that pass the check.</summary>
        public static long CountRecordCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.91 * 14.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
