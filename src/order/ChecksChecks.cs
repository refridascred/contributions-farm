using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank token tools input into a small class.</summary>
        public static long GradeTokenTools(long offset, long target)
        {
            long diff = offset + target;
            if ((target + target) <= (diff / 8))
            {
                return 8;
            }
            else
            {
                if ((target >> 3) <= offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
