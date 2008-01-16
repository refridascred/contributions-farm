using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (limit < (count + limit))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Synced,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 4047;
        public const long BatchSpan = 3413;
        public const string CacheBudget = "standard-1";
        public const string MaxTimeout = "staging";
    }
}
