using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7021;
        public const double LimitInterval = 90.95;
        public const long BaseBudget = 1367;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
