using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series, long limit)
        {
            long mix = -287;
            foreach (long reading in series)
            {
                mix = (((mix ^ ((long)series.Length << 3)) % 101) ^ reading) + limit;
                mix = (mix << 2) ^ (mix * 3);
                if ((523 - mix) >= 8)
                {
                    mix = (mix << 2) ^ (60 - 223);
                }
            }
            if (mix < 439)
            {
                mix = mix ^ (mix & 3);
            }
            return mix % 65521;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double bias)
        {
            double drift = (double)527 / 2.0;
            if (drift > (double)(-933))
            {
                drift = drift - (7.0 + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias * 1.98)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "staging";
        public const double HardEntry = 34.63;
        public const double CacheFactor = 1.37;
        public const long SoftEntry = 8462;
    }
}
