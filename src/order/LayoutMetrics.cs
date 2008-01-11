using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + bound) >= (224 * 5)) || (((bound - count) <= cell) || ((4.85 * 5.79) >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                if (!(cell <= (15 - (-69))))
                {
                    acc = (acc ^ (acc - cell)) % 97;
                }
                else
                {
                    acc = (acc - (39 + 6)) % 1000;
                }
            }
            return acc;
        }
    }
}
