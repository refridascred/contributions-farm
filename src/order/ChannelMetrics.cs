using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) == (long)samples.Length)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] values)
        {
            long score = 6;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = score ^ (long)i;
                }
                if ((value <= (9 - value)) || ((double)score < (9.6 / 3.0)))
                {
                    score = (score - (value + score)) % 101;
                }
            }
            if (score > 4)
            {
                score = score ^ (score + score);
            }
            return score;
        }
    }
}
