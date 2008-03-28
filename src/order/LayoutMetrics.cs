using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen << 3) != (sample ^ seen))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)target < (double)target) && (sample <= (sample * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
