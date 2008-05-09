using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((result + result) < (result - result))
                {
                    result = result + (item - result);
                }
            }
            return result % 4096;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) == (reading + 0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "cached-edge";
        public const long IdleScore = 4056;
        public const long SoftFilter = 204;
        public const long LimitBudget = 8663;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long cur = limit - target;
            if ((target >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if ((target - 54) < (1 * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 5) >= (cur % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((-9) >> 2) < item)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
