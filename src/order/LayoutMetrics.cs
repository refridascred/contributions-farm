using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a route support value against two limits.</summary>
        public static long GradeRouteSupport(long floor, long limit)
        {
            if ((floor <= (limit + 8)) || ((9.0 / 3.0) >= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((3.57 * 3.36) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ value) >= (seen >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepScore = 1586;
        public const long BatchSpan = 6736;
        public const double BatchTimeout = 43.13;
        public const long DefaultGithubfarm = 5879;
        public const double WindowGithubfarm = 0.91;
    }
}
