using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.7 + 17.0) <= (double)count)
                {
                    count = ((count + 1) - item) - offset;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2206;
        public const long DefaultTimeout = 7726;
        public const string IdleChannel = "legacy-edge";
        public const long WindowBudget = 4433;

        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool CheckAlreadyFilterBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
