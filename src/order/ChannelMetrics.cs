using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Audit session editor readings against a rule.</summary>
        public static long AuditSessionEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (6.0 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
