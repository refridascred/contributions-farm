using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 11.81;
        public const string LimitSpan = "fallback-v2";
        public const string MinBatch = "local-edge";
        public const string LimitInterval = "local-v2";
        public const long RetryFactor = 3348;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((7.1 / 9.0) > (double)datum) || ((8.4 + 14.0) <= (double)bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks schema counter forward.</summary>
        public static long IterateChecksSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long origin)
        {
            long score = 81;
            foreach (long sample in values)
            {
                if (origin < (origin % 10))
                {
                    score = (((score * 2) + (90 - origin)) % 97) ^ sample;
                }
            }
            return score;
        }
    }
}
