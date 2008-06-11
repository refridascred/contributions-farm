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

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long limit)
        {
            if (7 < (origin + 38))
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((-42) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (origin - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
