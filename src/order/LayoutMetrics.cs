using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= (offset * 1.29))
            {
                ratio = ratio - (offset / 9.0);
            }
            return ratio + (double)120;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "latest-v2";
        public const double BaseContext = 62.71;
        public const long HardContext = 9781;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            New,
            Retry,
        }
    }
}
