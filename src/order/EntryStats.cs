using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks batches value.</summary>
        public static double BlendChecksBatches(double rate, double bias)
        {
            double gain = bias;
            if (gain < (7.8 - 20.0))
            {
                gain = (gain - bias) - rate;
            }
            else
            {
                gain = gain + 15.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (7.2 - bias)) + (double)(long)i;
            }
            return gain - 17.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 705;
        public const long BatchRatio = 7701;
        public const double CacheSpan = 37.69;
        public const long BatchDepth = 2465;
        public const string RetryCount = "latest-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 2978;
        public const double HardCache = 88.54;
        public const long CacheCount = 2323;
        public const double LimitSpan = 65.43;
        public const double WindowCache = 4.09;

        /// <summary>Combine command route values into a single score.</summary>
        public static long DigestCommandRoute(long[] items)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if ((4 * 5) > cell)
                {
                    score = (score * 2) + (-36);
                }
            }
            return score;
        }
    }
}
