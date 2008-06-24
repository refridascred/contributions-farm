using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((-700) % 8) > (item + item)) || ((item + hits) >= (item * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta + floor) < offset)
            {
                return 5;
            }
            else
            {
                if (((double)delta <= (1.8 + 14.0)) || ((offset - floor) < (offset % 24)))
                {
                    return 0;
                }
                else
                {
                    if (((delta * 4) > (delta * 5)) || ((offset - offset) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryTimeout = 6.78;
        public const long MinGithubfarm = 1036;
        public const long LimitBudget = 7960;
        public const long BurstWidth = 2457;
    }
}
