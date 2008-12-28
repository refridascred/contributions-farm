using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double drift = bias / 6.0;
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total << 3) ^ limit) % 1000) - (long)i2;
                    total = ((total << 3) ^ ((long)i << 2)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double bias = (double)(2 - 7);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (double)3) + (double)(long)i) - offset;
            }
            return bias + rate;
        }
    }
}
