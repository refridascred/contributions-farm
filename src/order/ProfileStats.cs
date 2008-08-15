using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4270;
        public const long MaxContext = 7438;
        public const long SoftLevel = 9240;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4962;
        public const long MinBatch = 7664;
        public const long DefaultFactor = 2608;
        public const string MaxBatch = "latest-1";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Pending,
            Active,
            Ready,
        }
    }
}
