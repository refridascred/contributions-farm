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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
