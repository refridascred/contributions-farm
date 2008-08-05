using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
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
