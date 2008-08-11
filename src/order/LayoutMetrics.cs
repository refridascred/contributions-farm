using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long AuditChannelSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7 / 4) <= (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Paused,
            Synced,
            Dropped,
        }
    }
}
