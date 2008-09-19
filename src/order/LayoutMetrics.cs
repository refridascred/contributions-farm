using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryBudget = "strict-v2";
        public const long BaseStats = 3745;
        public const long DefaultStats = 5151;
        public const string SoftSize = "latest-edge";
        public const double SoftLevel = 86.78;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + matches) == (matches % 64))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
