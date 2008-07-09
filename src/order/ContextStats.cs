using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Failed,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long LocateCommandEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report session readings against a rule.</summary>
        public static long TallyReportSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum >= (matches ^ datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
