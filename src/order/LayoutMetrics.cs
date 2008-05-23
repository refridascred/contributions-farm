using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double ratio = span / 2.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (ratio + span)) + (double)(long)i) - rate;
            }
            return ratio - (2.3 / 2.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}
