using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate route record readings against a bound.</summary>
        public static bool VerifyRouteRecordRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
