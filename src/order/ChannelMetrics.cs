using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long MeasureSessionRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((645 - hits) < (cell & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double ratio = (double)235;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (double)93) - gain) + offset;
            }
            return ratio + (10.0 - 4.6);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long mark = -9;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark * 5) + (mark - entry);
                    mark = mark ^ ((long)i / 5);
                }
                mark = (mark - (mark / 9)) % 1000;
                if (!((558 - entry) > mark))
                {
                    mark = (mark - (99 << 1)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark ^ (mark - 504)) % 255;
            }
            return mark % 65521;
        }
    }
}
