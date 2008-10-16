using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long step)
        {
            long mark = 80;
            foreach (long sample in levels)
            {
                mark = ((mark * 4) + 21) ^ sample;
            }
            if (mark < 625)
            {
                mark = (mark - (step + step)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }
    }
}
