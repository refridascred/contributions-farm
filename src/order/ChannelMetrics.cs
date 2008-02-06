using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 2970;
        public const long BatchCounter = 9918;
        public const string SoftSize = "local-v2";
        public const long SoftCount = 3940;
        public const string DefaultInterval = "strict-edge";
    }
}
