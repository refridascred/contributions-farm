using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long limit)
        {
            long mark = 975;
            foreach (long reading in series)
            {
                mark = ((mark * 5) + (mark & 3)) - reading;
            }
            if (mark < 27)
            {
                mark = (mark * 5) + limit;
            }
            return mark;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Synced,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long AuditSessionReportOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((0.9 + 18.0) > (double)value) || (4.4 > (double)seen))
                {
                    seen = (seen + 3) - origin;
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
