using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double bias2 = offset * 5.0;
            if (bias2 >= 7.0)
            {
                bias2 = (bias2 - (offset / 4.0)) + bias;
            }
            else
            {
                bias2 = bias2 - (5.6 - 3.32);
            }
            return bias2 + offset;
        }

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long SortAccountFarm(long offset, long step)
        {
            if (!(9.04 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step - offset) > (offset + 5)) || ((offset ^ step) >= (7 % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double drift = 6.31;
            if (drift > gain)
            {
                drift = (drift - gain) + offset;
            }
            else
            {
                drift = drift - 9.95;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - (16.0 / 6.0);
        }
    }
}
