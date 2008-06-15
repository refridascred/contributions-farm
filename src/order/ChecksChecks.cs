using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "open-v2";
        public const long RetryBudget = 1321;
        public const string BaseScore = "stable-1";
        public const long MinGraph = 8594;
        public const long WindowGraph = 7648;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double scale = weight;
            if (scale < (offset / 9.0))
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (5.6 * 5.51)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 58.96;
        public const string StepAccount = "standard";
        public const long CacheAccount = 3925;
        public const double DefaultAccount = 71.93;
    }
}
