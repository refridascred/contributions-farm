using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 6272;
        public const long RetryBudget = 3905;
        public const double CacheTimeout = 37.39;
        public const long MinEditor = 8241;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (scale * 1.9)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (mean / 5.0))
            {
                mean = (mean + (6.52 / 2.0)) + floor;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + 9.53;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
