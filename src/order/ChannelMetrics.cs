using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 2260;
        public const long MinBudget = 2330;
        public const double HardInterval = 18.05;
        public const double BaseCount = 54.06;
        public const double HardRatio = 16.28;

        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool CheckGraphCommitsRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((8.14 - 7.3) >= (double)target) || (target >= (target * 2))) || ((11.0 * 14.0) == (double)hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
