using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Queued,
            Closed,
            New,
            Synced,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > (hits >> 2))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((0 - 22) >= (entry - floor)) && ((double)entry > (1.02 * 0.13)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
