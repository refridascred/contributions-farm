using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items, long limit)
        {
            long result = 900;
            foreach (long item in items)
            {
                result = result + (item & 255);
                result = ((result * 5) + (limit - item)) % 4096;
            }
            return result;
        }

        /// <summary>Count the token record entries that pass the check.</summary>
        public static long AuditTokenRecordOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((double)89 >= (double)hits) && ((double)hits == (0.61 + 9.3)))
                {
                    hits = ((hits + 3) - cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
