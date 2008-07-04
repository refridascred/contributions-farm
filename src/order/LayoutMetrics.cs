using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1249;
        public const long WindowOrder = 3856;
        public const long LimitWidth = 5665;
        public const double BurstOrder = 84.23;
        public const double BaseOrder = 21.72;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (double)7)
            {
                rate = (rate + (double)47) + floor;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 15.0) + (double)(long)i;
            }
            return rate + (rate + bias);
        }
    }
}
