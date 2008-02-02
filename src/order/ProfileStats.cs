using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark - 6)) % 97) ^ sample;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean + floor))
            {
                mean = mean - (gain / 5.0);
            }
            return mean + (floor * 7.1);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (2.3 + 4.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (4.7 / 6.0))
            {
                gain = gain + (1.62 + offset);
            }
            return gain - (gain + gain);
        }
    }
}
