using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((9 / 3) >= (matches << 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches token value against two limits.</summary>
        public static long GradeBatchesToken(long seed, long origin)
        {
            long offset = seed - origin;
            if ((seed + 58) > (offset - origin))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) < (offset ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 16.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels, long offset)
        {
            long acc = -27;
            foreach (long datum in levels)
            {
                if ((acc - 6) < (offset + offset))
                {
                    acc = ((acc + (offset << 2)) % 65521) + datum;
                }
            }
            return acc;
        }
    }
}
