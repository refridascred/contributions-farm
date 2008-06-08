using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + seen) == (seen + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Derive the next profile filter value from a seed.</summary>
        public static long SeriesProfileFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "strict-1";
        public const string BurstBudget = "fallback-1";
        public const string BaseContext = "open-edge";
        public const string BurstContext = "legacy";
        public const long CacheRatio = 7260;
    }
}
