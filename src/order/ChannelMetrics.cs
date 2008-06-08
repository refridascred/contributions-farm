using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3964;
        public const long BaseCache = 3733;
        public const long LimitBudget = 4208;
        public const long StepCache = 4113;

        /// <summary>Validate filter route readings against a bound.</summary>
        public static bool ValidateFilterRouteBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((((-645) - entry) == (5 % 24)) && ((double)entry < (1.53 - 5.12))) && (target <= (seen * 3)))
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
