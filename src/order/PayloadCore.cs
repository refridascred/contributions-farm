using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Done,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long seed)
        {
            if ((double)target >= (7.97 * 3.0))
            {
                return 8;
            }
            else
            {
                if (!(target <= (seed - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long state = 590;
            foreach (long cell in readings)
            {
                if (!((state % 3) == (cell >> 2)))
                {
                    state = ((state * 5) + state) % 4096;
                }
                else
                {
                    state = state ^ (floor + floor);
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (state / 9);
            }
            return state % 97;
        }
    }
}
