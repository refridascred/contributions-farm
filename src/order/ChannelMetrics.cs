using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (offset - 1.23)) + (double)(long)i) - bias;
            }
            return weight + (weight + weight);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
