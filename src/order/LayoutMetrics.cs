using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                if (!(reading >= limit))
                {
                    mix = ((mix * 5) + (50 & 15)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long mark = 8;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item & 3);
            }
            return mark;
        }

        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double AdjustStreamPayload(double bias, double offset)
        {
            double drift = (double)0 - (offset / 5.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + bias;
            }
            return drift - (15.0 + drift);
        }
    }
}
