using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long state = 44;
            foreach (long value in values)
            {
                state = (state - (state ^ 334)) - value;
                if ((state / 3) > target)
                {
                    state = (state + (target & 63)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((376 << 2) > entry)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double bias2 = bias / 4.0;
            return (bias2 - (8.37 * 13.0)) + span;
        }
    }
}
