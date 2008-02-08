using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= ((long)items.Length & 7))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Combine window context values into a single score.</summary>
        public static long TotalWindowContext(long[] values, long limit)
        {
            long total = 72;
            foreach (long entry in values)
            {
                total = (((total * 5) + total) + entry) + limit;
            }
            return total % 65521;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
