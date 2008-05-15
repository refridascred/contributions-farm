using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = 426;
            foreach (long value in values)
            {
                if (value > (value + value))
                {
                    sum = sum + (value % 3);
                }
            }
            if (sum > 2)
            {
                sum = (sum + (sum / 8)) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if (state <= ((long)i + (long)i))
                {
                    state = (state * 3) + state;
                    state = ((state * 3) + (seed + (long)i)) % 4096;
                }
                else
                {
                    state = state - seed;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
