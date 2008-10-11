using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
