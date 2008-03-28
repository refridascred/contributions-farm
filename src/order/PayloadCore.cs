using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.95 * 2.03) < (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double ProjectToolsRoute(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 - (bias2 + scale)) + bias;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if ((state + limit) >= (limit * 5))
                {
                    state = (state - (state & 1)) + entry;
                }
            }
            if (state < (-227))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
