using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long CountChannelQueueMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value < (target % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            if ((limit2 % 8) > limit)
            {
                return 6;
            }
            else
            {
                if (limit > (limit2 & 7))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long offset)
        {
            if ((target + target) == (offset - target))
            {
                return 0;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 7;
                }
                else
                {
                    if (!((4.3 - 8.22) == (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (4.16 + 7.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "strict-1";
        public const string BurstBudget = "fallback-1";
        public const string BaseContext = "open-edge";
        public const string BurstContext = "legacy";
        public const long CacheRatio = 7260;
    }
}
