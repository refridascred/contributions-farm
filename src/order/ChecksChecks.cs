using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(cell < (8 - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster payload value against two limits.</summary>
        public static long GradeClusterPayload(long origin, long target)
        {
            long offset = origin - target;
            if ((1.82 / 9.0) > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((offset / 2) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
