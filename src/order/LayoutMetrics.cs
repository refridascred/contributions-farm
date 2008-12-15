using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long state = 25;
            foreach (long reading in samples)
            {
                if (((state - reading) < (state & 7)) || ((reading * 5) == (state + 2)))
                {
                    state = state + (44 & 31);
                }
                else
                {
                    state = state + (reading + reading);
                }
            }
            if (state > 29)
            {
                state = ((state * 4) + (state % 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            New,
            Ready,
            Active,
            Failed,
        }
    }
}
