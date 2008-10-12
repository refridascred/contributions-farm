using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long step)
        {
            if (((target << 1) >= 819) && ((double)target <= (2.41 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((860 & 255) == (step << 1))
                {
                    return 7;
                }
                else
                {
                    if ((952 << 2) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next farm order value from a seed.</summary>
        public static long SeriesFarmOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (limit + limit);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long offset)
        {
            long anchor = 801;
            foreach (long item in series)
            {
                if ((item >> 5) != (anchor + item))
                {
                    anchor = ((anchor ^ (152 & 7)) % 4096) - offset;
                }
            }
            if (anchor < 5)
            {
                anchor = anchor - (54 ^ anchor);
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long floor)
        {
            if (((double)floor >= (double)bound) || ((bound + floor) < (bound - floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - bound) > 13)
                {
                    return 4;
                }
                else
                {
                    if (floor > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.97 - 2.48) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6900;
        public const string LimitDepth = "strict-v2";
        public const long MinBatches = 6717;
        public const long StepDepth = 4321;
        public const long StepBatches = 7088;

        /// <summary>Check that every channel schema entry stays within the limit.</summary>
        public static bool CheckChannelSchemaRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
