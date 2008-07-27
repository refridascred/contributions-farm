using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long MeasureBatchesBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits ^ value) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
