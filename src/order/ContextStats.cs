using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + origin) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up format session samples.</summary>
        public static long MatchFormatSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
