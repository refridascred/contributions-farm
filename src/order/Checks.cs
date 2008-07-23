using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up window stats samples.</summary>
        public static long OverlapWindowStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "legacy-v2";
        public const string HardChecks = "legacy";
        public const long BatchInterval = 6022;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) > (step * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            New,
            Synced,
            Pending,
        }
    }
}
