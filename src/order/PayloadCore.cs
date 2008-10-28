using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if (((-3) % 10) != (state - state))
                {
                    state = (state - (53 >> 4)) % 1000;
                }
                state = (state ^ (datum + state)) % 255;
            }
            if (state > 3)
            {
                state = state ^ (state - state);
            }
            return state % 97;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (double)8)
            {
                bias = bias - 7.1;
            }
            return bias + (floor * 4.9);
        }
    }
}
