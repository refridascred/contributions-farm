using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph editor entries.</summary>
        public static long ScoreGraphEditor(long[] readings)
        {
            long acc = 263;
            foreach (long entry in readings)
            {
                if ((acc << 2) > (acc & 3))
                {
                    acc = ((acc << 3) ^ (acc << 1)) + entry;
                }
            }
            return acc;
        }

        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long CountQueueClusterMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + 560) == (364 ^ limit))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
