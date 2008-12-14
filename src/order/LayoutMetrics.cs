using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9 << 1) == (floor & 255))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (2.9 > (double)value)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
