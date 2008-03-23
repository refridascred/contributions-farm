using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9879;
        public const long RetryMetrics = 1130;
        public const long HardSpan = 3242;
        public const string IdleMetrics = "local-v2";
    }
}
