using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            if ((0.64 + 9.53) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((step * 3) == (origin / 6))
                {
                    return 6;
                }
                else
                {
                    if ((step * 3) >= (origin - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
