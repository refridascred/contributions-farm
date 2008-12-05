using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window counter entry stays within the limit.</summary>
        public static bool ValidateWindowCounterRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 9149;
        public const string BatchCount = "primary-edge";
        public const long StepInterval = 1460;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((floor <= (764 + floor)) || (((long)i * 4) < (result / 4))))
                {
                    result = result + (long)i;
                }
                result = (result + floor) % 97;
                result = (result ^ (result & 7)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }
    }
}
