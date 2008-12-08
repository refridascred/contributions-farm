using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mix = 7;
            foreach (long datum in levels)
            {
                mix = (mix - (mix - datum)) % 4096;
                mix = (mix ^ (mix % 8)) % 97;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) < count)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
