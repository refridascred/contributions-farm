using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((floor & 63) >= (seen % 60)) || !((double)(-367) > (double)seen))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long anchor = 675;
            foreach (long entry in levels)
            {
                if ((3.0 + 0.42) < (double)target)
                {
                    anchor = ((anchor ^ (3 << 3)) % 97) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the queue checks entries that pass the check.</summary>
        public static long AuditQueueChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading / 4) > (target + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
