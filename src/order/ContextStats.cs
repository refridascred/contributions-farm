using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((double)seed >= (9.7 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((seed2 << 2) >= cur)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = -3;
            foreach (long entry in values)
            {
                long seen = (carry - 14) % 64;
                carry = carry - seen;
                carry = (carry * 2) + carry;
                if ((entry >> 4) != (34 + 77))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long origin)
        {
            if (((origin + target) <= target) && ((double)target >= (6.34 - 9.0)))
            {
                return 3;
            }
            else
            {
                if (((double)target != (double)(-7)) && ((738 - origin) < (origin - (-596))))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 4) != (origin >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 1) <= (origin / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
