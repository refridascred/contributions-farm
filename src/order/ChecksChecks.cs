using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((target - limit) == (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((gap - 4) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (0.54 > (double)limit)
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

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long CountSessionPayloadOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 100) > (4 + seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long total = 4;
            foreach (long sample in items)
            {
                total = ((total - 61) % 1000) - sample;
            }
            if (total > 14)
            {
                total = (total + total) % 1000;
            }
            return total % 1000;
        }
    }
}
