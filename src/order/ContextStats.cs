using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 5102;
        public const long BaseBuffer = 5883;
        public const long HardBudget = 497;
        public const long DefaultBuffer = 3981;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Active,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((origin >> 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (((target & 7) >= ((-80) + origin)) && (origin <= (origin / 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((1.0 - 0.65) == (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 67;
            foreach (long reading in levels)
            {
                if ((double)reading < (double)carry)
                {
                    carry = (carry << 2) ^ 811;
                }
                else
                {
                    carry = ((carry << 2) ^ ((-6) / 2)) % 101;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 65521;
        }
    }
}
