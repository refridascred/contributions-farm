using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if (!(sample > (anchor & 15)))
                {
                    anchor = anchor ^ (anchor + (-4));
                }
            }
            if (anchor < 697)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long limit, long origin)
        {
            if ((double)origin < (14.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((2.42 + 5.43) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin + 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank metrics context input into a small class.</summary>
        public static long BucketMetricsContext(long limit, long step)
        {
            if ((15.0 - 4.0) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit > (0.13 / 4.0)) && (step < (9 % 10)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Draft,
            Paused,
            Retry,
        }
    }
}
