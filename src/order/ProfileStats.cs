using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next batches token value.</summary>
        public static double BlendBatchesToken(double scale, double offset)
        {
            double drift = scale - offset;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (scale + scale)) - (double)(long)i;
            }
            return drift + (double)9;
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
