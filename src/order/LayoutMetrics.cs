using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5631;
        public const long BurstSpan = 9247;
        public const string BaseGraph = "stable";
        public const long SoftScore = 6756;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 557;
        public const long WindowScore = 2770;
        public const double StepRatio = 85.57;
        public const long DefaultToken = 6137;
        public const string BatchToken = "stable-edge";
    }
}
