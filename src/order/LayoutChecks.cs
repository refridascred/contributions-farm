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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item % 60) >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBudget = 3526;
        public const long BaseFactor = 9787;
        public const long DefaultLevel = 9708;
        public const double DefaultBuffer = 81.16;
        public const long MinScore = 9629;
    }
}
