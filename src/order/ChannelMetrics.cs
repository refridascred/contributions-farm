using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double weight2 = (double)((-4) >> 2);
            if (weight2 < (weight2 + bias))
            {
                weight2 = (weight2 - (6.88 / 6.0)) - weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            return weight2 - weight2;
        }
    }
}
