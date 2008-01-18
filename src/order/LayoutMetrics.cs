using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((double)seed == (double)cell) || (((long)values.Length + cell) >= tally)) || (5 < (cell - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long anchor = 214;
            foreach (long sample in items)
            {
                anchor = (((anchor << 3) ^ ((-1) >> 4)) % 4096) + sample;
                anchor = (anchor - (anchor % 5)) % 101;
            }
            return anchor;
        }
    }
}
