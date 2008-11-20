using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long target)
        {
            if (!(2.0 <= (double)target))
            {
                return 8;
            }
            else
            {
                if (((double)target > (double)276) || ((345 + target) > target))
                {
                    return 3;
                }
                else
                {
                    if (((origin - origin) <= target) && ((target >> 5) == (target & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) >= (728 ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "latest-v2";
        public const double StepBudget = 41.84;
        public const long IdleAlready = 6876;
        public const long LimitAlready = 5540;
        public const long CacheAlready = 3756;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long CountFormatProfileGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 < (count ^ count)) && ((9.04 >= (double)count) || (count < 71)))
                {
                    count = ((count + 2) - entry) + step;
                }
            }
            return count;
        }
    }
}
