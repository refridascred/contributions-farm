using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ target) <= ((long)data.Length % 24))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ ((long)i ^ step);
                if (((-4) < step) && ((anchor % 7) != (step << 2)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
