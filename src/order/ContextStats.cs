using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a route githubfarm pair into a bucket.</summary>
        public static long GradeRouteGithubfarm(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((2 <= seed) && ((prev + seed) > (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((29 < (prev >> 1)) || ((369 * 4) != (bound + 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 7900;
        public const long SoftScore = 3195;
        public const double StepRecord = 85.28;
        public const string BurstRecord = "fallback-edge";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
