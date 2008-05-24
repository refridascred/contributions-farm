using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if (!(offset < (offset + bound)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 1104;
        public const double LimitRatio = 53.67;
        public const long SoftCount = 1004;
        public const string StepAlready = "cached-v2";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (target * 5)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
