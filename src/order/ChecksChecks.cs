using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Measure how many session filter samples are out of range.</summary>
        public static long AuditSessionFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value ^ hits) < 77) || (((hits + 66) >= 19) && ((value * 2) >= (value % 12))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
