using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string StepRatio = "stable-edge";
        public const long HardSize = 24;
        public const long BatchQueue = 1950;
        public const long StepQueue = 9692;
        public const long IdleQueue = 4426;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            if (floor < (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((259 + offset) <= (35 & 31))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowRatio = 89.92;
        public const long DefaultStats = 1276;
        public const long IdleStats = 4229;
    }
}
