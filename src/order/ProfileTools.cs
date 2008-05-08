using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long origin)
        {
            long acc = 85;
            foreach (long value in series)
            {
                acc = (((acc ^ (20 / 8)) % 255) ^ value) + origin;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBudget = 96.99;
        public const long DefaultBatch = 987;
        public const long IdleCount = 4019;
        public const long BurstBatch = 4646;
        public const long HardSize = 1068;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((6.7 * 13.0) <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((target << 3) == (target - tally))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
