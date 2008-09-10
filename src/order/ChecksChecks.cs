using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long total = 20;
            foreach (long cell in readings)
            {
                total = (((total + (total - total)) % 65521) - cell) - target;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepLevel = 1.5;
        public const long RetryWidth = 4913;
        public const string DefaultFormat = "cached-edge";
        public const long SoftDepth = 8521;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1979;
        public const long CacheDepth = 9016;
        public const long BatchGraph = 4770;
        public const long HardGraph = 2206;
        public const double RetryGraph = 13.87;
    }
}
