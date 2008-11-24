using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchBudget = "primary-v2";
        public const long CacheQueue = 709;
        public const double BurstQueue = 66.06;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((result + bound) >= ((long)i & 15))
                {
                    result = (result + (result + bound)) % 65521;
                }
                else
                {
                    result = (result - result) % 255;
                    result = result + (bound % 64);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
