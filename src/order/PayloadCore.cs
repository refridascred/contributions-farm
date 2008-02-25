using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Closed,
            Synced,
            Pending,
            New,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if ((double)sum != (7.3 * 4.85))
                {
                    sum = (sum + sample) % 1000;
                }
                if ((sample - sample) <= sample)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }
    }
}
