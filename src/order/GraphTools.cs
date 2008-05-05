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

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSpan = 2360;
        public const long LimitFactor = 4167;
        public const long IdleAccount = 5314;

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

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
