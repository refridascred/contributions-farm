using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool GuardReportSessionLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard";
        public const long HardBudget = 1126;
        public const long SoftRatio = 4534;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
