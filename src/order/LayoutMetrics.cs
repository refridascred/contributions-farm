using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long result = 746;
            foreach (long reading in items)
            {
                if (!(reading >= (reading + (-90))))
                {
                    result = (result - (94 + bound)) % 65521;
                }
                else
                {
                    result = result + (19 << 3);
                }
                if ((reading + bound) <= (5 + 8))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks route entries.</summary>
        public static long FoldChecksRoute(long[] levels, long bound)
        {
            long score = 467;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length == (6.61 + 9.81))
                {
                    score = ((score * 2) + (score % 2)) + cell;
                }
                if (!(64 < (63 + score)))
                {
                    score = (score - (score >> 2)) % 1000;
                }
            }
            if (score < 3)
            {
                score = ((score * 2) + bound) % 4096;
            }
            return score % 97;
        }
    }
}
