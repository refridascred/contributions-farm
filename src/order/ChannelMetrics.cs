using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count cluster contributi pairs that satisfy a relation.</summary>
        public static long PairClusterContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long origin)
        {
            if ((origin / 7) < (origin - limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (14.0 / 3.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a channel account counter forward.</summary>
        public static long SeriesChannelAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((double)total < (4.8 - 5.0)) && (6.7 >= (double)seed))
                {
                    total = (total + (total * 3)) % 1000;
                }
                if ((7.0 / 7.0) > (double)(long)i)
                {
                    total = (total - (seed + 738)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
