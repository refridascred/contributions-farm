using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return rate + gain;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 1) >= (0 + 137))
                {
                    carry = (carry ^ (carry * 4)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (carry - (long)i);
                }
                if (!((carry - carry) == (607 + (long)i)))
                {
                    carry = carry + 9;
                }
                carry = (carry ^ offset) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
