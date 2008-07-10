using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Ready,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
