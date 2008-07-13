using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 600;
        public const long RetryRatio = 6409;
        public const long BurstFactor = 9879;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = 643;
            foreach (long value in levels)
            {
                if (value > (value - value))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (total >> 1)) % 65521;
                }
            }
            if (total < 1)
            {
                total = ((total * 2) + (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long state = 5;
            foreach (long cell in series)
            {
                long matches = (state << 2) + (state % 7);
                if (((cell / 8) > (state << 1)) || ((73 & 127) >= matches))
                {
                    matches = (matches * 4) + (434 % 64);
                }
                state = (state + state) % 4096;
            }
            if (state > (-52))
            {
                state = ((state * 5) + (state / 5)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
