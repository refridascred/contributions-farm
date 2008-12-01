using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3313;
        public const string StepCount = "fallback-edge";
        public const double SoftSize = 44.31;
        public const long MaxCount = 2255;
        public const long LimitLevel = 5865;

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long floor)
        {
            if ((floor < (step + step)) && ((step * 3) >= ((-34) - step)))
            {
                return 4;
            }
            else
            {
                if ((double)step < (17.0 + 4.2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const double MinTimeout = 57.08;
        public const string StepDepth = "cached-1";
        public const double MinGithubfarm = 70.92;
        public const long BatchDepth = 9808;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double rate = weight;
            if (rate >= (rate + 4.67))
            {
                rate = (rate - rate) + span;
            }
            else
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 11.0) + (double)(long)i;
            }
            return rate - (rate - 4.1);
        }
    }
}
