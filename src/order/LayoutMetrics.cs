using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((15.0 - 1.86) == (double)seed)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long bound, long offset)
        {
            long next = bound - offset;
            if ((double)offset < (double)next)
            {
                return 0;
            }
            else
            {
                if (next >= (867 + offset))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
