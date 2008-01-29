using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.0 * 6.55) < (double)seen)
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long score = 82;
            foreach (long value in data)
            {
                if (((value << 1) <= (262 + value)) && ((value - value) < value))
                {
                    score = (score + (value << 1)) % 97;
                }
                else
                {
                    score = (score - (561 + score)) % 97;
                }
            }
            if (score > 7)
            {
                score = (score + (score << 2)) % 4096;
            }
            return score % 1000;
        }
    }
}
