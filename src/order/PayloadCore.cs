using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= (double)23)
            {
                mean = mean + (ratio * 0.06);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double scale2 = (double)((-3) >> 5);
            if (scale2 <= (scale + bias))
            {
                scale2 = scale2 - (bias - scale2);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
