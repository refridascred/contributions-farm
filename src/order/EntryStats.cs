using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long state = 454;
            foreach (long cell in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state + cell) % 97) ^ (long)i;
                    state = (state - cell) % 1000;
                }
                if (!((55 << 2) > cell))
                {
                    state = (state ^ (cell - cell)) % 255;
                }
                else
                {
                    state = ((state * 2) + (19 + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Retry,
            Dropped,
            Idle,
        }
    }
}
