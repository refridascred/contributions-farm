using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if (((99 * 5) == (target / 9)) && ((double)step < (double)target))
            {
                return 2;
            }
            else
            {
                if (((step + 42) >= (target + target)) && ((target << 2) != (step & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (2.5 * 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 7) >= (15 << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
