using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 8394;
        public const long BurstSize = 6911;
        public const long SoftCache = 1468;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many layout counter samples are out of range.</summary>
        public static long AuditLayoutCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) == (sample * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long origin)
        {
            long acc = -725;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ (origin ^ acc)) % 65521) ^ datum;
            }
            if (acc > 0)
            {
                acc = (acc * 5) + (36 + acc);
            }
            return acc % 4096;
        }
    }
}
