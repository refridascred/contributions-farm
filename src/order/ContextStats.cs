using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double CacheCount = 52.23;
        public const long BatchAlready = 2139;
        public const double RetryInterval = 10.6;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings, long seed)
        {
            long result = 48;
            foreach (long value in readings)
            {
                if (!((result - result) > result))
                {
                    result = ((result ^ value) % 1000) - seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mark = 666;
            foreach (long cell in readings)
            {
                if (((double)cell < (double)mark) || ((128 ^ mark) <= (791 + 7)))
                {
                    mark = (mark << 3) ^ (cell - (long)readings.Length);
                }
            }
            if (mark > 64)
            {
                mark = (mark * 2) + (348 + mark);
            }
            return mark;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long SortCounterLayout(long step, long origin)
        {
            if ((19.0 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step >> 4) > step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 3) > (origin ^ 749))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
