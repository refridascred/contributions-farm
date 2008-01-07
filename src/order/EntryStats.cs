using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 95;
        public const long StepTimeout = 1947;
        public const long RetrySize = 146;
        public const string SoftWidth = "strict-edge";
        public const long SoftSchema = 663;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Synced,
            New,
            Draft,
            Idle,
        }
    }
}
