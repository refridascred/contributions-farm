using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 3) > (cell % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank command filter input into a small class.</summary>
        public static long GradeCommandFilter(long origin, long seed)
        {
            if ((double)origin < (0.3 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) != (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 + 8.0) <= (double)origin)
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

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long ScoreLayoutBatch(long[] series, long offset)
        {
            long mix = 44;
            foreach (long item in series)
            {
                if (((66 * 2) <= (item + mix)) && ((item % 10) == (mix * 2)))
                {
                    mix = ((mix - (1 << 1)) % 101) + offset;
                }
            }
            return mix;
        }
    }
}
