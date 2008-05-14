using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seed + sample) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long GradeReportBatches(long target, long seed)
        {
            if (!((target << 1) > (seed % 5)))
            {
                return 1;
            }
            else
            {
                if ((target <= (target / 3)) || ((double)seed >= (double)1))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (2.9 + 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.57 - 9.0) < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
