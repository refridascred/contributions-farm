using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "primary";
        public const double BurstBudget = 64.0;
        public const long BaseReport = 6681;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSpan = 2051;
        public const long BatchChannel = 3233;
        public const double BaseLevel = 24.48;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double load = (double)(8 + 4);
            if (load >= bias)
            {
                load = load + (floor * 1.57);
            }
            else
            {
                load = load - load;
            }
            return load - (load * 17.0);
        }
    }
}
