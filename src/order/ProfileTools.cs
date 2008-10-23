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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long bound)
        {
            long carry = 31;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (carry + (long)levels.Length)) % 4096) + datum) + bound;
            }
            if (carry > 809)
            {
                carry = ((carry * 2) + ((long)levels.Length - carry)) % 101;
            }
            return carry;
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
