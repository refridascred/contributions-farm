using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next route counter value.</summary>
        public static double AdjustRouteCounter(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < (ratio / 9.0))
            {
                rate = (rate + ratio) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (ratio * 16.0);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((sample & 255) == (55 / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (504 < cell)
                {
                    result = (result ^ (924 / 3)) % 97;
                }
                if (!((cell % 7) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long AuditSchemaFormatHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((8.4 / 4.0) != (double)hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
