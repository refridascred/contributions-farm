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

        /// <summary>Classify a tools layout pair into a bucket.</summary>
        public static long SortToolsLayout(long limit, long target)
        {
            long gap = limit - target;
            if ((gap % 10) < (gap * 5))
            {
                return 0;
            }
            else
            {
                if ((limit > (0 + gap)) && (limit <= 93))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
