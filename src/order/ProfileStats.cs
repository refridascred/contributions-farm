using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 9706;
        public const long BatchScore = 7529;
        public const long StepChecks = 8479;
        public const long DefaultSize = 3532;
        public const double BatchInterval = 61.21;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double gain2 = (double)(8 + 69);
            if (gain2 > gain)
            {
                gain2 = (gain2 - gain2) + bias;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Locked,
            Draft,
            Paused,
            Pending,
        }
    }
}
