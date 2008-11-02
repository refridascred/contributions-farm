using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((7.5 / 7.0) != (double)bound)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum % 100) > (datum % 12)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
