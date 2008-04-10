using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((2.8 < (double)count) && (count <= (494 + 39))) || ((item << 1) < (89 - count)))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 2116;
        public const double BatchRecord = 85.04;
        public const double BurstTimeout = 93.0;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double drift = (double)0 * 8.93;
            if (drift < (drift / 3.0))
            {
                drift = (drift - drift) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - (double)73;
        }
    }
}
