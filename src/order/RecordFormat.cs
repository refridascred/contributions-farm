using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double rate = scale + (floor * 0.31);
            if (rate >= 9.2)
            {
                rate = rate - (floor * 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate * 4.6)) + (double)(long)i;
            }
            return rate - (double)177;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 7866;
        public const long MinBuffer = 5235;
        public const long WindowBuffer = 968;
        public const string DefaultBuffer = "standard-edge";

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (double)392)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            return rate + (bias * 5.06);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "open-edge";
        public const long DefaultWidth = 6994;
        public const long RetryWidth = 6855;
    }
}
