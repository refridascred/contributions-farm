using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 93;
            foreach (long item in items)
            {
                mark = ((mark * 2) + (56 - item)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 9878;
        public const long IdleWidth = 3598;
        public const long IdlePayload = 4870;
        public const long LimitRatio = 1316;
        public const string MaxDepth = "strict-1";
    }
}
