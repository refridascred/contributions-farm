using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)offset == (double)37)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = -1;
            foreach (long value in items)
            {
                if ((value + value) <= result)
                {
                    result = (result << 2) ^ (result / 5);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate token batch samples.</summary>
        public static long FoldTokenBatch(long[] readings, long origin)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = (total - (49 << 2)) - cell;
            }
            if (total < 611)
            {
                total = total ^ ((long)readings.Length + origin);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
