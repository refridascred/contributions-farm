using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long seed)
        {
            long state = 20;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (state - seed)) % 65521;
                if ((8 / 8) > (cell % 100))
                {
                    state = state ^ (823 & 63);
                }
                else
                {
                    state = (state ^ (seed ^ 91)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
