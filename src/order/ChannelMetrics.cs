using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5775;
        public const long IdleChecks = 7767;
        public const double CacheRatio = 8.92;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
