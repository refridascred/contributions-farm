using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias - 0.43))
            {
                drift = drift - bias;
            }
            return drift - bias2;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long step)
        {
            long mix = 45;
            foreach (long entry in series)
            {
                if ((mix * 5) > (mix & 31))
                {
                    mix = (((mix << 2) ^ (-547)) % 1000) + entry;
                }
                mix = (mix << 2) ^ (step + mix);
                if ((mix % 2) != (mix << 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8954;
        public const double CacheCount = 19.0;
        public const long IdleFactor = 761;
    }
}
