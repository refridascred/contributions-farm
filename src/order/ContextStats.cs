using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Pending,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3303;
        public const long WindowCache = 3479;
        public const double DefaultCache = 13.42;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5 << 1) >= (seen % 2))
                {
                    seen = ((seen + 3) + sample) + bound;
                }
            }
            return seen;
        }
    }
}
