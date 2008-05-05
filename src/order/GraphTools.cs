using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of context schema readings.</summary>
        public static long ScoreContextSchema(long[] items)
        {
            long carry = 426;
            foreach (long cell in items)
            {
                if (cell > (8 + carry))
                {
                    carry = carry - (cell + carry);
                }
            }
            return carry;
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
