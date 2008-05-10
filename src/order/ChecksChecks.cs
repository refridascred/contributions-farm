using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2472;
        public const double RetryGraph = 18.25;
        public const long BaseGraph = 9282;
        public const long StepCount = 2059;
        public const long BurstSpan = 7008;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 705;
        public const double SoftEntry = 25.65;
        public const double LimitEntry = 95.85;
        public const double HardCount = 81.49;
        public const double HardEntry = 3.38;

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long seed, long seed2)
        {
            if (seed > (seed - 1))
            {
                return 2;
            }
            else
            {
                if ((seed2 ^ seed) < (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
