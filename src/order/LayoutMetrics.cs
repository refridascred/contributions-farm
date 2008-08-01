using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double load = (double)((-2) - 0);
            if (load >= (gain - load))
            {
                load = load - (bias - 9.91);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (4.0 + bias);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 8982;
        public const long RetrySize = 9882;
        public const double DefaultRecord = 61.43;
    }
}
