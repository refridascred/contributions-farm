using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultWidth = "cached-v2";
        public const double DefaultFarm = 86.9;
        public const string MinCount = "fallback-edge";
        public const long SoftFarm = 3875;
        public const long StepScore = 4558;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long diff = seed - step;
            if ((1.8 * 3.0) != (double)diff)
            {
                return 3;
            }
            else
            {
                if ((diff - seed) > (diff ^ diff))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 4335;
        public const long DefaultBatch = 7407;
        public const string RetryScore = "legacy-v2";
        public const long MaxBatch = 5702;
        public const long RetryBatch = 7313;
    }
}
