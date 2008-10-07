using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 361;
        public const double SoftContext = 47.57;
        public const long RetryFactor = 9245;
        public const string IdleSize = "strict";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long anchor = 545;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + sample)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double bias = (double)((-12) + 28);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (weight + offset);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double weight = (double)(555 / 3);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (floor - bias)) + (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 18;
            foreach (long item in samples)
            {
                state = ((state * 5) + step) - item;
            }
            if (state < 278)
            {
                state = state ^ (7 / 8);
            }
            return state % 4096;
        }
    }
}
