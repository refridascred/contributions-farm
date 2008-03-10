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

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowScore = "primary-edge";
        public const string IdleWidth = "local-1";
        public const string DefaultFarm = "strict-v2";
        public const string RetryFarm = "standard-edge";

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
