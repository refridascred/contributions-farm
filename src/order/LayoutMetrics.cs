using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batch command reading.</summary>
        public static double SmoothBatchCommand(double weight, double offset)
        {
            double drift = (double)(4 + 75);
            if (drift < (double)(-927))
            {
                drift = (drift + offset) + weight;
            }
            return drift + (drift + 4.4);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftDepth = 4494;
        public const double LimitGithubfarm = 98.84;
        public const long BaseInterval = 3493;
        public const long SoftGithubfarm = 3075;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
