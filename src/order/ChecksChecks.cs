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

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long slot = target ^ target2;
            if ((slot + target2) > (0 ^ 3))
            {
                return 8;
            }
            else
            {
                if ((slot * 5) < 405)
                {
                    return 1;
                }
                else
                {
                    if ((target <= (target2 / 2)) && ((target2 + target) < (target2 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
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
