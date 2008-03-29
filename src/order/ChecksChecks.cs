using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 34.77;
        public const string BaseCounter = "legacy-v2";
        public const long BurstCounter = 9070;
        public const long BurstFactor = 5740;
        public const long StepCounter = 2268;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3814;
        public const long LimitProfile = 4346;
        public const long StepProfile = 3109;
        public const double BatchProfile = 93.54;

        /// <summary>Locate a order channel reading by value.</summary>
        public static long FindOrderChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
