using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6180;
        public const string MinTimeout = "open-edge";
        public const long DefaultAccount = 9853;
        public const long BurstDepth = 2122;
        public const double BaseAccount = 69.49;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (result <= (target % 64))
                {
                    result = result + ((long)i + 73);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Derive the next already tools value from a seed.</summary>
        public static long StepAlreadyTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
