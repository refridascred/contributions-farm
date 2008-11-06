using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long SeriesProfileCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (533 % 7)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length % 100) != (datum >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
