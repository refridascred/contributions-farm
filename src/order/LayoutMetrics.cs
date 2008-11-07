using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long StepCluster = 5904;
        public const long MinCluster = 1065;
        public const long BurstRatio = 5075;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((double)limit2 == (9.2 * 19.0))
            {
                return 3;
            }
            else
            {
                if ((limit2 + diff) > (limit2 << 1))
                {
                    return 2;
                }
                else
                {
                    if ((diff >> 1) <= diff)
                    {
                        return 8;
                    }
                    else
                    {
                        if (867 < (941 - limit2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
