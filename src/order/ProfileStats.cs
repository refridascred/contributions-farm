using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((carry + 714) >= (long)i)
                {
                    carry = ((carry << 2) ^ (step - step)) % 97;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double bias = ratio;
            return (bias - (double)617) + offset;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Ready,
            Active,
            Pending,
        }
    }
}
