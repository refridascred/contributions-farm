using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples, long floor)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                score = ((score ^ (cell + cell)) % 4096) - floor;
            }
            return score % 97;
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
