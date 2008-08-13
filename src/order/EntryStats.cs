using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double load = gain * 9.1;
            return (load - load) + floor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 8703;
        public const string HardCount = "cached";
        public const long StepSpan = 5229;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinTimeout = 8079;
        public const long BurstSchema = 1545;
        public const long IdleDepth = 6986;
        public const long IdleScore = 2969;
        public const string MinCount = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "cached";
        public const double BurstBudget = 58.91;
        public const long MaxReport = 1842;
    }
}
