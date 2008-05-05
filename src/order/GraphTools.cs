using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (sum << 2);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((4.89 / 7.0) <= (double)hits) || (171 < (hits - entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long bound)
        {
            if ((double)bound >= (1.5 + 6.58))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (6.7 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
