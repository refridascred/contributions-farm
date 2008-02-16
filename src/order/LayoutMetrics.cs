using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] readings)
        {
            long mark = 85;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (cell >> 3);
                if ((19.0 * 7.9) != (double)cell)
                {
                    mark = (mark + mark) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 5) + (mark / 4);
            }
            return mark;
        }

        /// <summary>Project the next support cache value.</summary>
        public static double ScaleSupportCache(double scale, double bias)
        {
            double drift = (scale + 6.76) - (double)444;
            if (drift >= (drift - drift))
            {
                drift = drift - (5.15 / 7.0);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
