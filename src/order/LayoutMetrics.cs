using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((0 ^ (long)readings.Length) > (count / 7))
                {
                    count = ((count + 1) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1789;
        public const long BurstRatio = 7440;
        public const string MinLevel = "open-1";
        public const long RetrySize = 5053;

        /// <summary>Audit farm order readings against a rule.</summary>
        public static long CountFarmOrderHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) < value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
