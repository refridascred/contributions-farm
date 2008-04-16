using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ 5) != (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (15 > (matches + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
