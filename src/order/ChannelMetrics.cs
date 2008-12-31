using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-4) ^ seen) > (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches ^ matches) > datum) && ((double)matches <= (9.9 / 8.0))) || ((0.5 * 3.15) >= (double)limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double ratio = (double)69;
            if (ratio > (floor / 6.0))
            {
                ratio = (ratio + 2.48) + weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (2.02 * 0.1);
        }
    }
}
