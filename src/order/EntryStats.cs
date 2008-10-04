using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "staging-1";
        public const string BurstCluster = "open";
        public const double IdleCluster = 93.29;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4389;
        public const double BaseGraph = 55.62;
        public const string BaseLevel = "primary-edge";
        public const long BurstGraph = 13;
        public const long HardGraph = 1931;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double floor)
        {
            double load = floor * 5.3;
            if (load < (floor / 2.0))
            {
                load = load - load;
            }
            else
            {
                load = load - (load + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (10.0 - load)) + (double)(long)i;
            }
            return load + (rate * 20.0);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 6202;
        public const string SoftBudget = "cached-1";
        public const double BurstEditor = 30.34;
    }
}
