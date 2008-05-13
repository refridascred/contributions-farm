using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftScore = 3335;
        public const long BatchGithubfarm = 216;
        public const long MinScore = 5726;
        public const long BatchLevel = 3968;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double bias2 = (double)(756 / 5);
            if (bias2 < (bias2 + bias))
            {
                bias2 = (bias2 - bias) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 6.0)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }
    }
}
