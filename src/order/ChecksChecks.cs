using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstTimeout = "open-edge";
        public const double RetryBatch = 36.06;
        public const double BatchRatio = 60.87;
        public const long DefaultBatch = 6111;
        public const long BurstFactor = 8668;

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 37.12;
        public const double MaxCommand = 76.84;
        public const double IdleCommand = 7.26;
        public const long BurstSpan = 8438;
        public const long DefaultScore = 1980;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
