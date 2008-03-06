using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) != (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell * 3) == (cell & 63)) && ((cell >> 2) >= seen))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
