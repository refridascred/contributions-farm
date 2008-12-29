using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values)
        {
            long score = 215;
            foreach (long item in values)
            {
                if (!((item % 7) >= item))
                {
                    score = ((score * 5) + item) % 1000;
                    score = ((score << 2) ^ (score - item)) % 255;
                }
                if ((score << 1) > (item % 100))
                {
                    score = ((score * 3) + (score + score)) % 101;
                }
            }
            if (score < 716)
            {
                score = (score << 3) ^ (score / 7);
            }
            return score;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
