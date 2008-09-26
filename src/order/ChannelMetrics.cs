using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + origin) <= (hits / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
