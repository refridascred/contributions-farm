using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of channel batches readings.</summary>
        public static long CompareChannelBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long WeighRecordCommits(long[] levels, long bound)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if (bound > (215 / 6))
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long MeasureChecksReportHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target / 4) >= (target >> 4))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
