using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Grade a route window value against two limits.</summary>
        public static long GradeRouteWindow(long seed, long bound)
        {
            if ((bound < (bound % 2)) || ((bound - bound) < (53 & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)seed > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((5 > seed) && ((double)bound < (5.4 - 7.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) >= (seed - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long AuditContextCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.96 * 6.3) != (double)floor)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
