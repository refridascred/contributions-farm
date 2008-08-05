using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a counter batch reading by value.</summary>
        public static long LocateCounterBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((58 >> 3) >= (matches >> 3))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 8420;
        public const long MaxScore = 5371;
        public const long CacheSupport = 2374;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long total = 809;
            foreach (long cell in readings)
            {
                total = (total * 5) + total;
                if (6.7 >= (double)cell)
                {
                    total = ((total << 3) ^ (cell + total)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
