using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of buffer tools readings.</summary>
        public static long CompareBufferToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long AuditProfileStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.8 - 16.0) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
