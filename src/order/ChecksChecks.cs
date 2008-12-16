using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 49.09;
        public const double BatchRecord = 28.07;
        public const long MaxRecord = 1420;

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long AuditReportCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= (98 + 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a farm checks value against two limits.</summary>
        public static long GradeFarmChecks(long floor, long target)
        {
            long slot = floor ^ target;
            if ((11.0 / 2.0) <= (double)target)
            {
                return 0;
            }
            else
            {
                if (!(floor <= (target % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((slot < target) || ((4.0 + 11.0) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
