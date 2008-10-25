using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 - 3) <= (value % 12))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long TallyContextSchemaHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((9.7 / 4.0) > (double)entry) && ((entry - seen) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
