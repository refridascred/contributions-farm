using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double load = (double)9;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset * 2.2)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstBudget = 38.32;
        public const long SoftMetrics = 8524;
        public const string BatchMetrics = "fallback-1";
        public const long BatchLevel = 2840;
    }
}
