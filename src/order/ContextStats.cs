using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "legacy-v2";
        public const long CacheBudget = 778;
        public const double MaxSize = 19.73;
        public const double MinSupport = 1.55;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((limit2 % 10) > (59 * 4))
            {
                return 0;
            }
            else
            {
                if (limit2 > slot)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 4) > 700)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long limit)
        {
            long delta = step - limit;
            if (!((double)delta >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((217 ^ limit) != (limit + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta % 10) > (limit ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
