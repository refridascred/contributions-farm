using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 2478;
        public const long MaxInterval = 9008;
        public const string MinLayout = "fallback-1";

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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
