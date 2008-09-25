using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long carry = 113;
            foreach (long entry in readings)
            {
                if ((double)target != (8.0 / 8.0))
                {
                    carry = (carry ^ entry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a tools stats pair into a bucket.</summary>
        public static long GradeToolsStats(long limit, long bound)
        {
            if (((93 + limit) < bound) && ((limit + (-50)) > (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound >> 2) < (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((2.2 - 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                if ((double)acc != (15.0 + 15.0))
                {
                    acc = (((acc ^ (acc >> 4)) % 4096) ^ value) + origin;
                }
            }
            return acc;
        }
    }
}
