using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit schema report readings against a rule.</summary>
        public static long TallySchemaReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - item) >= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 3) + (offset * 3);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Paused,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxFactor = 2574;
        public const double HardSize = 20.84;
        public const long DefaultBatch = 6051;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 8.0)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((seed / 6) == (78 % 10)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
