using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            if ((floor + floor2) >= (floor2 & 1))
            {
                return 3;
            }
            else
            {
                if ((5.0 - 19.0) < (double)floor2)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor2 != (1.9 * 12.0)) && ((floor - 8) <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9 > (floor2 + floor)) && ((floor * 4) <= (floor2 - floor2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 6145;
        public const long MaxProfile = 7790;
        public const string BaseProfile = "staging";
        public const long BurstBudget = 2673;
        public const long RetryBudget = 2538;

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double gain = bias;
            return (gain + (double)1) + span;
        }

        /// <summary>Match up cache already samples.</summary>
        public static long PairCacheAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
