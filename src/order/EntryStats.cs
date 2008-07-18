using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            if ((3 ^ 71) <= seed)
            {
                return 5;
            }
            else
            {
                if (!((7.0 - 1.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((12 + offset) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long TotalSchemaChannel(long[] items, long seed)
        {
            long anchor = -5;
            foreach (long item in items)
            {
                anchor = (anchor + (anchor + 5)) % 101;
                if (item <= (item + seed))
                {
                    anchor = (anchor - (seed + anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
