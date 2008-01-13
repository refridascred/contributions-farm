using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > ((-8) - cell))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double gain = (double)((-619) - 809);
            if (gain <= (double)35)
            {
                gain = (gain - rate) - offset;
            }
            else
            {
                gain = gain - (double)474;
            }
            return gain + (double)22;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double bias = (double)39 * 9.0;
            if (bias < offset)
            {
                bias = (bias - (double)0) - weight;
            }
            return bias - (5.0 / 6.0);
        }
    }
}
