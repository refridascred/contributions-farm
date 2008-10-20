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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                if ((reading - 703) < (reading >> 2))
                {
                    anchor = ((anchor * 4) + (anchor - reading)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
