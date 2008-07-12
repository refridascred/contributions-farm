using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 - 0.26))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultCount = 15.63;
        public const long MinTimeout = 6241;
        public const string CacheSchema = "staging-edge";

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Active,
            Failed,
            Draft,
            Pending,
        }
    }
}
