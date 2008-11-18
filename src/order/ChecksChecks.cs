using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if (!((315 + bound) > bound))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (2 + origin)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (8.2 / 9.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
