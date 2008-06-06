using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double ratio2 = (double)(7 % 12);
            if (ratio2 <= (4.17 / 7.0))
            {
                ratio2 = (ratio2 + (ratio2 / 2.0)) - span;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + ratio;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double drift = rate;
            if (drift >= floor)
            {
                drift = drift - (drift / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (floor * 2.92)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((4.83 - 6.0) == (double)seen) && (((double)seen > 16.0) || ((entry - entry) <= 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
