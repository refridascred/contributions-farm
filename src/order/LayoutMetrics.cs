using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long limit)
        {
            long prev = seed + limit;
            if (prev <= (60 - limit))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (19.0 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((17.0 / 2.0) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm token samples.</summary>
        public static long WeighGithubfarmToken(long[] levels, long offset)
        {
            long state = 565;
            foreach (long sample in levels)
            {
                if ((31 * 5) < (sample >> 1))
                {
                    state = (((state * 4) + (sample + sample)) % 97) - offset;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((111 / 2) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
