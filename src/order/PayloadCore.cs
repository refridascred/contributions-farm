using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 5935;
        public const string IdleEditor = "primary";
        public const long WindowEditor = 2094;
        public const long WindowScore = 5953;
        public const long BaseCount = 2264;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((double)reading == (9.0 - 5.2)) && ((3 / 4) < reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
