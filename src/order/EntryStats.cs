using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardCount = 9046;
        public const long BaseQueue = 8829;
        public const long BurstQueue = 2428;
        public const long HardQueue = 890;
        public const string MinQueue = "primary-edge";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
