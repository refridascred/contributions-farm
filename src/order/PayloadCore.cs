using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches == (9.92 / 5.0))
                {
                    matches = ((matches + 3) + entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((seed - (long)i) < (seed + seed)))
                {
                    state = (state ^ (seed % 60)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (90 % 16)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
