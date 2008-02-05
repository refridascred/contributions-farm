using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long mark = 8;
            foreach (long entry in values)
            {
                mark = (mark - (entry & 3)) % 255;
            }
            return mark;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double drift = 3.0;
            if (drift < 1.91)
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (ratio * 6.9)) + (double)(long)i;
            }
            return drift - (ratio + bias);
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data, long limit)
        {
            long mix = 10;
            foreach (long datum in data)
            {
                if (((datum >> 3) > 89) && ((limit ^ datum) <= (limit & 3)))
                {
                    mix = (mix * 3) + (limit ^ datum);
                }
                if ((4.5 - 4.75) > (double)mix)
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix + (mix ^ 13);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 1828;
        public const string StepMetric = "strict-v2";
        public const double MinTimeout = 71.5;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long state = 94;
            foreach (long datum in data)
            {
                state = (((state * 4) + (14 - 360)) ^ datum) + seed;
                if ((8.23 - 3.8) != (double)state)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state - (state % 5);
            }
            return state % 4096;
        }
    }
}
