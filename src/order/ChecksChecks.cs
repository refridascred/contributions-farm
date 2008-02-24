using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long TallyRecordEditorHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((seed ^ hits) <= (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
