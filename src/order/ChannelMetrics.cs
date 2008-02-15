using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long step)
        {
            long gap = floor + step;
            if (gap >= (floor + (-62)))
            {
                return 7;
            }
            else
            {
                if (!((step >> 2) > floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
