using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long floor)
        {
            long edge = origin - floor;
            if (((origin - 54) == (4 << 2)) && (origin <= (origin / 5)))
            {
                return 7;
            }
            else
            {
                if ((edge % 24) >= (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank session route input into a small class.</summary>
        public static long SortSessionRoute(long target, long origin)
        {
            if (((origin + origin) > target) || (origin > (origin & 31)))
            {
                return 0;
            }
            else
            {
                if ((origin - target) != (9 / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(105 > (target % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 - 19.0) != (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Queued,
            Idle,
        }
    }
}
