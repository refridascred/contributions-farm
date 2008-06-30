using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((long)values.Length < (offset - matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed >= delta)
            {
                return 5;
            }
            else
            {
                if (seed > (delta - bound))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 160) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
