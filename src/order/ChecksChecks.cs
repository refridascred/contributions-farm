using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Retry,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits >= (17.0 * 9.84))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 1205;
        public const string DefaultCount = "strict-1";
        public const double LimitOrder = 23.91;
        public const long SoftOrder = 6904;
    }
}
