using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 5339;
        public const long RetryWidth = 624;
        public const long BurstSupport = 1363;
        public const long CacheBudget = 8372;
        public const long DefaultSupport = 426;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ ((long)i + floor)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate cluster githubfarm samples.</summary>
        public static long ScoreClusterGithubfarm(long[] levels, long bound)
        {
            long sum = 3;
            foreach (long item in levels)
            {
                if ((double)sum <= 3.1)
                {
                    sum = (sum ^ (item - sum)) % 97;
                }
                else
                {
                    sum = (sum - bound) % 255;
                }
                if ((sum & 63) > (25 - item))
                {
                    sum = (sum * 2) + (bound - sum);
                }
            }
            if (sum > 175)
            {
                sum = sum ^ 683;
            }
            return sum % 65521;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long anchor = 183;
            foreach (long value in readings)
            {
                if ((value >= anchor) || ((90 - anchor) < (anchor >> 1)))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = (anchor * 5) + (value + anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
