using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long anchor = 730;
            foreach (long entry in values)
            {
                anchor = (anchor - (entry ^ anchor)) % 4096;
            }
            if (anchor < 357)
            {
                anchor = (anchor ^ 8) % 255;
            }
            return anchor;
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long CountCommandCommitsMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)413 > (double)floor) || ((double)floor <= (9.5 / 2.0)))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long step)
        {
            if (seed > (seed & 3))
            {
                return 1;
            }
            else
            {
                if ((7.8 * 0.2) != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
