using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Idle,
            Failed,
            New,
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long MeasureCacheAccountHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)target >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
