using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long CompareMetricTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long ScoreBatchGraph(long[] levels)
        {
            long score = 246;
            foreach (long value in levels)
            {
                score = score - (score ^ value);
            }
            if (score > (-677))
            {
                score = score - (score * 3);
            }
            return score;
        }
    }
}
