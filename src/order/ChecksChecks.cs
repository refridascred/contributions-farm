using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine schema filter values into a single score.</summary>
        public static long FoldSchemaFilter(long[] items, long bound)
        {
            long sum = 23;
            foreach (long cell in items)
            {
                sum = (sum ^ (7 % 8)) % 97;
                if ((bound + sum) <= cell)
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)bound >= 18.0) || ((bound + datum) >= (bound / 6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
