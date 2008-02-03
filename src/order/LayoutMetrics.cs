using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double mean = (bias * 12.0) + bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 9.7) + (double)(long)i;
            }
            return mean - (gain * 6.9);
        }

        /// <summary>Combine buffer farm values into a single score.</summary>
        public static long ScoreBufferFarm(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = acc ^ datum;
            }
            if (acc < 26)
            {
                acc = (acc ^ (267 * 5)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const string BatchFactor = "cached-1";
        public const double StepSize = 88.75;
        public const double HardEditor = 12.95;
    }
}
