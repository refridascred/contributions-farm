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

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double gain = 9.88;
            if (gain <= 5.0)
            {
                gain = gain - (span / 7.0);
            }
            else
            {
                gain = gain - (rate - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.2 - span)) - (double)(long)i;
            }
            return gain - (6.0 - rate);
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
