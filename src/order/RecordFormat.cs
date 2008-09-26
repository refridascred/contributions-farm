using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitScore = "open-1";
        public const long CacheBudget = 5184;
        public const long HardTools = 3058;
        public const long CacheTools = 3444;
        public const long RetryTools = 9843;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((step ^ hits) > sample) || ((2.45 * 9.6) >= (double)hits)) && !((double)step < (5.6 / 9.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ (long)i) > (score * 2))
                {
                    score = (score ^ score) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (score - score)) % 65521;
                    score = score ^ (target >> 4);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long DeriveGraphToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
