using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload format counter forward.</summary>
        public static long StepPayloadFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double drift = (floor + floor) * 1.0;
            return (drift - drift) + ratio;
        }
    }
}
