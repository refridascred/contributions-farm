using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the stream metric entries that pass the check.</summary>
        public static long CountStreamMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(9.5 < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= ratio)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)79) + (double)(long)i;
            }
            return rate + (double)9;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits < 4)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }
    }
}
