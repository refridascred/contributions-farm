using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 92.12;
        public const string BatchTimeout = "standard-v2";
        public const long BatchDepth = 1879;
        public const long CacheScore = 5227;
        public const long DefaultContext = 6446;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long limit)
        {
            long bound = seed ^ limit;
            if ((limit + limit) <= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((limit + seed) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((seed > (seed + bound)) || ((bound & 3) != (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)698 > (double)seed) || (3.18 > (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long offset)
        {
            if ((floor & 63) != (offset % 60))
            {
                return 1;
            }
            else
            {
                if (offset <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ floor) > (floor + offset))
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
