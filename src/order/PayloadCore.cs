using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double ratio = (3.86 - scale) + (double)93;
            if (ratio <= (double)(-3))
            {
                ratio = (ratio + (scale / 8.0)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)755) + (double)(long)i;
            }
            return ratio + (9.48 / 8.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading <= tally) && ((double)reading >= (double)7))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)(-591)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long FoldRouteSession(long[] samples, long bound)
        {
            long mix = 38;
            foreach (long cell in samples)
            {
                if (((9.0 / 4.0) != (double)bound) || ((bound * 3) <= mix))
                {
                    mix = ((mix << 3) ^ (bound / 3)) ^ cell;
                }
            }
            if (mix < 36)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }
    }
}
