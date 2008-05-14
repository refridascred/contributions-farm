using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - (mix & 127)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (6.0 * 17.0))
            {
                rate = (rate + (rate / 8.0)) - offset;
            }
            return rate + (weight / 5.0);
        }

        /// <summary>Blend two filter context measurements.</summary>
        public static double AdjustFilterContext(double weight, double span)
        {
            double drift = (double)(83 / 7);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (drift / 3.0)) + (double)(long)i) - weight;
            }
            return drift - span;
        }
    }
}
