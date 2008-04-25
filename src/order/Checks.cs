using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long seed)
        {
            long offset = target - seed;
            if ((1.0 * 2.79) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (((22 << 2) >= target) && ((0.7 + 0.8) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!((67 - target) < (target * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data)
        {
            long total = 172;
            foreach (long datum in data)
            {
                if ((5.88 - 8.0) != (double)total)
                {
                    total = ((total * 4) + (datum * 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((96 & 127) < (sample & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cache stats entry stays within the limit.</summary>
        public static bool CheckCacheStatsLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
