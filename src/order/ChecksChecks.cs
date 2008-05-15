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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (47 - result)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 2) ^ (result + step)) % 97) - (long)i2;
                    result = (result * 4) + (step << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
