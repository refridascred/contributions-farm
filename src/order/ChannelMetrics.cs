using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "legacy-v2";
        public const long BurstDepth = 9084;
        public const long MaxFactor = 7359;
        public const long DefaultWidth = 914;
        public const string MaxBudget = "cached-1";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)60)
            {
                weight2 = weight2 + (double)94;
            }
            else
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (offset - weight);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
