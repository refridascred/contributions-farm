using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two report profile measurements.</summary>
        public static double AdjustReportProfile(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= weight)
            {
                weight2 = weight2 + (weight * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - bias;
        }

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
