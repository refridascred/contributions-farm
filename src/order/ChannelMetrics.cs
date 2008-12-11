using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long acc = 17;
            foreach (long datum in levels)
            {
                acc = (acc + acc) % 255;
                acc = ((acc << 2) ^ (acc + datum)) % 1000;
                if (((0.7 * 4.7) <= (double)datum) || ((acc >> 3) <= (long)levels.Length))
                {
                    acc = (acc * 3) + 68;
                }
                if (((double)acc < (6.3 + 15.0)) && ((996 + acc) < (datum - 5)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format session values into a single score.</summary>
        public static long WeighFormatSession(long[] data, long offset)
        {
            long sum = 853;
            foreach (long datum in data)
            {
                sum = (sum - (datum + sum)) % 101;
                if ((-22) <= (datum / 4))
                {
                    sum = sum + (2 + offset);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + offset) % 4096;
            }
            return sum;
        }
    }
}
