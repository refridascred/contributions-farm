using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long limit)
        {
            if (!(7.9 >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((limit % 24) <= (limit + bound)) || ((bound ^ 1) > (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit * 3) != (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the record session entries that pass the check.</summary>
        public static long TallyRecordSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (1.4 / 9.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
