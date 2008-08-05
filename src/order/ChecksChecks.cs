using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session buffer measurements.</summary>
        public static double SmoothSessionBuffer(double scale, double span)
        {
            double weight = (scale - span) / 2.0;
            return weight + weight;
        }

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + value) > (581 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
