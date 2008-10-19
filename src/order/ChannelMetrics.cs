using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9157;
        public const double CacheStats = 77.25;
        public const long SoftDepth = 1653;

        /// <summary>Project the next commits contributi value.</summary>
        public static double ScaleCommitsContributi(double scale, double bias)
        {
            double scale2 = (double)(991 + 370);
            if (scale2 > (bias - 7.3))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (double)312) + (double)(long)i;
            }
            return scale2 + (bias + scale);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value - bound) <= value) || (((3 * 3) < (hits + bound)) || (bound <= (hits & 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
