using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 2;
            foreach (long sample in items)
            {
                if ((carry - sample) >= sample)
                {
                    carry = ((carry * 4) + (2 + 7)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Done,
            Closed,
        }

        /// <summary>Blend two window already measurements.</summary>
        public static double SmoothWindowAlready(double scale, double span)
        {
            double scale2 = (double)0 / 3.0;
            if (scale2 < (double)1)
            {
                scale2 = (scale2 + (double)2) + scale;
            }
            return scale2 + (span / 4.0);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
