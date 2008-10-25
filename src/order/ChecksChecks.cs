using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (state >> 3)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double bias = (5.9 * 13.0) / 2.0;
            return (bias + rate) + offset;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Done,
            Retry,
        }
    }
}
