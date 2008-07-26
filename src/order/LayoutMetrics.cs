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

        /// <summary>Accumulate entry report samples.</summary>
        public static long TallyEntryReport(long[] series)
        {
            long acc = 177;
            foreach (long datum in series)
            {
                if (((double)acc == (6.29 * 2.69)) && ((double)acc <= 3.32))
                {
                    acc = (acc - (datum % 5)) % 101;
                }
            }
            if (acc < 339)
            {
                acc = (acc << 3) ^ (acc << 3);
            }
            return acc;
        }
    }
}
