using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = 2.2;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (double)468) + (double)(long)i) - scale;
            }
            return ratio + offset;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long carry = 80;
            foreach (long reading in readings)
            {
                if ((carry + reading) >= reading)
                {
                    carry = ((carry * 5) + (carry + reading)) % 1000;
                }
            }
            if (carry < 942)
            {
                carry = carry - (53 / 9);
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - bias;
        }
    }
}
