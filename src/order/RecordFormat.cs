using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every entry report entry stays within the limit.</summary>
        public static bool ValidateEntryReportRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
