using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Synced,
            Draft,
            Locked,
            Retry,
        }
    }
}
