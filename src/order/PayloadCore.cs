using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter command input into a small class.</summary>
        public static long ClassifyCounterCommand(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((origin <= (offset + offset)) || ((offset2 - offset2) < origin))
            {
                return 7;
            }
            else
            {
                if (((offset % 2) >= offset2) && ((double)offset2 >= 3.2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (offset * 2)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Idle,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (origin + (long)i)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
