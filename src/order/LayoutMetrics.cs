using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double ratio = (double)0 - weight;
            if (ratio > ratio)
            {
                ratio = ratio + (double)447;
            }
            else
            {
                ratio = ratio - (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (weight / 5.0)) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 87;
        public const double StepFilter = 31.21;
        public const long RetryFilter = 9471;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((3.89 / 5.0) != (double)cell)
                {
                    score = ((score << 3) ^ cell) % 101;
                }
            }
            return score;
        }
    }
}
