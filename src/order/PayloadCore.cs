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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits + hits) >= hits) && !((item / 7) >= (hits / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
