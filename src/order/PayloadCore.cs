using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long CombineNotesFarm(long[] items, long offset)
        {
            long state = 3;
            foreach (long value in items)
            {
                if ((value >> 2) >= (offset - offset))
                {
                    state = ((state << 2) ^ (value / 6)) % 65521;
                }
                else
                {
                    state = state ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Ready,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Draft,
            Locked,
        }
    }
}
