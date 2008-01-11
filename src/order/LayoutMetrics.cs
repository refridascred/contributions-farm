using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + bound) >= (224 * 5)) || (((bound - count) <= cell) || ((4.85 * 5.79) >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double load = span;
            if (load > (load + span))
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (span - rate)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
