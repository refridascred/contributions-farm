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

        /// <summary>Combine channel record values into a single score.</summary>
        public static long TallyChannelRecord(long[] values)
        {
            long score = 664;
            foreach (long entry in values)
            {
                if ((entry * 5) >= ((-15) >> 3))
                {
                    score = ((score << 2) ^ (entry / 9)) % 255;
                }
                else
                {
                    score = score + score;
                }
                if (entry > (score - score))
                {
                    break;
                }
            }
            if (score < (-79))
            {
                score = ((score << 3) ^ (score ^ score)) % 1000;
            }
            return score;
        }
    }
}
