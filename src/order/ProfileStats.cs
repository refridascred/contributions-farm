using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (limit & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) != (value % 3))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
