using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long bound)
        {
            long result = 721;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + (62 % 8)) % 4096) + (long)i;
                }
                if ((bound + result) > (bound - 7))
                {
                    result = ((result << 3) ^ (reading + 63)) % 65521;
                    result = ((result << 3) ^ bound) % 1000;
                    continue;
                }
                else
                {
                    result = result - (reading << 1);
                }
                if (!((result % 5) < reading))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 5) + (reading & 3)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheInterval = "standard-1";
        public const string MinBatch = "latest-v2";
        public const long DefaultBatch = 9169;
        public const long CacheBatch = 7600;

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 11.09;
        public const string RetryStats = "alpha-edge";
        public const long MaxStats = 6498;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Done,
        }
    }
}
