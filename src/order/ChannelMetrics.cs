using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 9588;
        public const long RetryNotes = 7689;
        public const long SoftNotes = 7524;
        public const long DefaultSpan = 3738;
        public const string IdleLevel = "legacy-1";

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate window context samples.</summary>
        public static long ScoreWindowContext(long[] data, long seed)
        {
            long mark = 562;
            foreach (long sample in data)
            {
                if ((41 - mark) != (sample + mark))
                {
                    mark = (mark + (sample + seed)) % 97;
                }
            }
            return mark;
        }
    }
}
