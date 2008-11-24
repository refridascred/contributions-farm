using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 5320;
        public const double RetryEditor = 0.39;
        public const long DefaultEditor = 4086;

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
