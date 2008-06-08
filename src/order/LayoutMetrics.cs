using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8010;
        public const string MaxTimeout = "local-edge";
        public const string CacheWindow = "cached";

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double mean = (double)(52 + 815);
            if (mean > (weight - 11.0))
            {
                mean = (mean + (double)(-638)) + span;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 341;
            foreach (long cell in items)
            {
                result = ((result * 2) + (result + cell)) % 1000;
            }
            return result;
        }
    }
}
