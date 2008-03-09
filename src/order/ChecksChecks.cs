using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long AuditReportLayoutHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (73 >= (step + count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
