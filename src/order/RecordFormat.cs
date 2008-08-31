using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up entry account samples.</summary>
        public static long CompareEntryAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((0.19 / 3.0) == (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long step)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                mark = (((mark ^ 175) % 97) + item) + step;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftSize = 4391;
        public const long IdleOrder = 7944;
        public const long IdleScore = 3306;
        public const long HardOrder = 7514;
        public const double HardTimeout = 66.36;
    }
}
