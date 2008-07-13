using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 600;
        public const long RetryRatio = 6409;
        public const long BurstFactor = 9879;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = 643;
            foreach (long value in levels)
            {
                if (value > (value - value))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (total >> 1)) % 65521;
                }
            }
            if (total < 1)
            {
                total = ((total * 2) + (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long MeasureToolsEditorHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 5) != (3 + limit))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
