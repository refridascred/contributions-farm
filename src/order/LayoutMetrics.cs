using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double mean = (double)(17 >> 4);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (bias + 6.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long result = 347;
            foreach (long datum in data)
            {
                result = result ^ (2 - datum);
            }
            if (result > 354)
            {
                result = result + (result >> 3);
            }
            return result % 1000;
        }
    }
}
