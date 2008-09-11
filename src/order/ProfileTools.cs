using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            if (((target ^ 866) <= 47) && ((double)target < (8.35 - 3.94)))
            {
                return 4;
            }
            else
            {
                if ((510 - target) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (2.0 - 5.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((147 > target) || ((target - bound) < (target / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long RankLayoutSchema(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((bound > delta) || ((double)delta < (double)bound))
            {
                return 2;
            }
            else
            {
                if ((bound / 5) <= 110)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 7) == (limit + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + bound) >= delta) || ((limit << 1) != (delta << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long target)
        {
            long acc = -87;
            foreach (long datum in levels)
            {
                acc = (((acc ^ acc) % 255) + datum) + target;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 7066;
        public const long WindowBudget = 1618;
        public const string MinCounter = "latest-1";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Closed,
            Ready,
            Paused,
        }
    }
}
