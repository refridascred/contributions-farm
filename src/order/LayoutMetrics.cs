using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token buffer entries.</summary>
        public static long TotalTokenBuffer(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = (((score * 3) + (2 ^ (-906))) % 4096) + entry;
            }
            return score;
        }

        /// <summary>Find the first counter contributi entry that matches the target.</summary>
        public static long LookupCounterContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
