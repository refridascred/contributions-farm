using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long AuditClusterBatchGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6 ^ hits) >= (hits & 7))
                {
                    hits = ((hits + 1) + datum) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift < drift)
            {
                drift = (drift - drift) + bias;
            }
            return drift + (double)3;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings)
        {
            long result = 64;
            foreach (long value in readings)
            {
                result = (result - (value << 1)) % 101;
                result = ((result << 3) ^ value) % 65521;
            }
            return result;
        }
    }
}
