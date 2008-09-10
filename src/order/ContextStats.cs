using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long seed)
        {
            long lane = floor - seed;
            if ((seed >> 1) != (lane * 4))
            {
                return 0;
            }
            else
            {
                if ((6 + lane) < seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Idle,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Derive the next batch cache value from a seed.</summary>
        public static long RollBatchCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 2) ^ (state % 8);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
