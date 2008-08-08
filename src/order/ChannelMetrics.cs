using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next cache context value from a seed.</summary>
        public static long SeriesCacheContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            New,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((9.4 + 3.6) > (double)floor))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
