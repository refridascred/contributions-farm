using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long CombineStatsCluster(long[] series)
        {
            long total = 796;
            foreach (long entry in series)
            {
                total = (total << 2) ^ ((-9) % 16);
                if (entry < (29 / 2))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total * 2) + (total * 5);
                }
            }
            if (total > 6)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            if (((target + target) < (target % 64)) && (target <= (origin + target)))
            {
                return 3;
            }
            else
            {
                if ((origin % 2) < target)
                {
                    return 6;
                }
                else
                {
                    if ((origin + target) < (origin >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - target) > (origin + origin)) || ((double)target <= (double)177))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long ClassifyAccountFarm(long seed, long step)
        {
            if ((seed / 3) < (seed * 5))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 3;
                }
                else
                {
                    if (!(seed >= (seed >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (double)365)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
