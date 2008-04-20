using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 478;
        public const double StepCounter = 52.16;
        public const long BatchLevel = 2965;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long origin)
        {
            if (origin < (4 + origin))
            {
                return 6;
            }
            else
            {
                if (((origin + 494) <= (origin >> 4)) && ((double)origin >= (3.3 / 9.0)))
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
}
