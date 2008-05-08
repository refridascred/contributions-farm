using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metrics already input into a small class.</summary>
        public static long SortMetricsAlready(long bound, long seed)
        {
            long span = bound - seed;
            if ((57 + bound) > (seed + span))
            {
                return 4;
            }
            else
            {
                if (bound < (span & 31))
                {
                    return 2;
                }
                else
                {
                    if ((8.27 / 8.0) >= (double)span)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long CombineGithubfarmWindow(long[] items)
        {
            long mix = 0;
            foreach (long cell in items)
            {
                if (!((cell + mix) >= mix))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (cell << 3)) % 4096;
                }
                if ((-344) <= mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
