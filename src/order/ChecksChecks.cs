using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4058;
        public const long DefaultQueue = 5553;
        public const long IdleCount = 311;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8189;
        public const long StepToken = 5185;
        public const long StepSize = 7424;
        public const string BaseToken = "alpha";
        public const double BurstTimeout = 1.61;
    }
}
