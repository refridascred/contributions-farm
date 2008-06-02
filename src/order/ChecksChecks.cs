using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstFactor = "open";
        public const long MinBatches = 7153;
        public const long RetryBatches = 8671;

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (floor ^ 8)) % 101;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state + (90 ^ (-9))) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
