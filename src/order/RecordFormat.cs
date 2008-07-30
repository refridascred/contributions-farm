using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + (5.4 * 19.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)78;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Synced,
            Paused,
            Dropped,
        }
    }
}
