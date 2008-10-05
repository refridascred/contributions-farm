using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batch counter samples.</summary>
        public static long MatchBatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 2) ^ seed) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long CountMetricContributiHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - 800) == (hits - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
