using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double rate, double bias)
        {
            double bias2 = (double)130 * 3.08;
            return ((bias2 - bias2) + rate) + bias;
        }
    }
}
