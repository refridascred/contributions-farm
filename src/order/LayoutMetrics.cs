using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double load = bias / 5.0;
            if (load < load)
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset * 6.5)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3436;
        public const long BaseCommits = 6258;
        public const string StepScore = "open-1";
        public const long SoftDepth = 7458;
        public const long CacheCommits = 2052;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long score = 37;
            foreach (long entry in levels)
            {
                if (!((double)entry == (double)84))
                {
                    score = (score * 2) + (score * 2);
                }
            }
            return score;
        }
    }
}
