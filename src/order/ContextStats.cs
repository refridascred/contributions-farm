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

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool CheckFilterSchemaBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
