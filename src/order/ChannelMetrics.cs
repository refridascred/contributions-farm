using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
