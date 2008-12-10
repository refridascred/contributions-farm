using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] samples)
        {
            long state = 23;
            foreach (long cell in samples)
            {
                state = (((state << 2) ^ state) % 97) - cell;
            }
            if (state < 34)
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Paused,
            New,
        }
    }
}
