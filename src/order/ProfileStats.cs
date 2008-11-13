using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultDepth = 9661;
        public const long WindowCount = 3534;
        public const string MaxRoute = "fallback-1";
        public const long StepScore = 1026;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step >= (long)i) && ((9.4 * 6.02) == (double)step))
                {
                    carry = (carry - (carry - step)) % 101;
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 5654;
        public const long WindowStream = 3334;
        public const long BatchSize = 6506;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "open";
        public const string LimitQueue = "open-edge";
        public const double HardTimeout = 97.15;
        public const long HardCount = 2138;
        public const long BaseCount = 3763;
    }
}
