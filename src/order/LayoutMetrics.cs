using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) >= (entry & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (2.2 > (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
