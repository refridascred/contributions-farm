using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Ready,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Queued,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the session already entries that pass the check.</summary>
        public static long TallySessionAlreadyHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((145 % 12) >= (count % 16))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }
    }
}
