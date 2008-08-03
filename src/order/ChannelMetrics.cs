using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count order filter pairs that satisfy a relation.</summary>
        public static long OverlapOrderFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double weight2 = (offset / 4.0) / 2.0;
            if (weight2 > weight)
            {
                weight2 = weight2 + 8.85;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            return weight2 + 6.9;
        }

        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long MeasureClusterSchemaGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((floor + floor) >= (548 & 7)) || (datum > floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
