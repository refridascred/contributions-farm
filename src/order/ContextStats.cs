using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen > (sample & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stats metrics input into a small class.</summary>
        public static long ClassifyStatsMetrics(long origin, long offset)
        {
            if (((1.9 + 17.0) <= (double)origin) || ((offset + origin) <= (offset % 8)))
            {
                return 5;
            }
            else
            {
                if ((origin + offset) >= (offset << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
