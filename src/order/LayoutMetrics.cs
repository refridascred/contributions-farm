using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double load = bias - (bias2 - bias);
            if (load < (bias2 * 4.0))
            {
                load = load + (8.48 + bias2);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)18) + (double)(long)i;
            }
            return load - (double)9;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((84 - seed2) == (seed & 15))
            {
                return 0;
            }
            else
            {
                if ((prev % 3) <= seed2)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 6479;
        public const long DefaultFilter = 6238;
        public const string BatchFilter = "cached-v2";
        public const long MinBudget = 9695;
        public const long StepFilter = 7165;
    }
}
