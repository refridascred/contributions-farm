using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long seed)
        {
            long span = bound ^ seed;
            if ((span + 6) < seed)
            {
                return 8;
            }
            else
            {
                if ((seed + 270) < bound)
                {
                    return 2;
                }
                else
                {
                    if (!((bound - seed) > span))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
