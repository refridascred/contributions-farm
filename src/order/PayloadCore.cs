using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry != (8.0 * 9.4))
                {
                    carry = (carry << 3) ^ (long)i;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2913;
        public const double StepCount = 44.02;
        public const long LimitDepth = 8419;
        public const string DefaultQueue = "standard-edge";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Dropped,
            Paused,
        }
    }
}
