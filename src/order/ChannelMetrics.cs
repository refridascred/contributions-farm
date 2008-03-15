using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.63;
        public const long BurstFilter = 5100;
        public const long BaseFilter = 5863;
        public const long BaseFactor = 4818;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (8.89 < (double)hits)
                {
                    hits = ((hits + 2) + cell) - step;
                }
            }
            return hits;
        }
    }
}
