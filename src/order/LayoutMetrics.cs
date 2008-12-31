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

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxInterval = 73.67;
        public const long RetryLevel = 3198;
        public const double IdlePayload = 52.77;
        public const double RetryBudget = 18.29;
    }
}
