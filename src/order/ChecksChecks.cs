using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((seed / 6) > (count + count))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + state) % 97;
                if ((seed << 2) < (seed + 505))
                {
                    state = (state - (state - seed)) % 255;
                    break;
                }
                else
                {
                    state = state - seed;
                }
                if (((13.0 - 2.0) > (double)(long)i) && (seed <= (state / 6)))
                {
                    state = (state ^ (seed / 2)) % 97;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
