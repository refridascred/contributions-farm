using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstLevel = 3112;
        public const string LimitChannel = "standard";
        public const long MinDepth = 3454;
        public const long StepRatio = 6573;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
