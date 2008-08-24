using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items)
        {
            long anchor = 31;
            foreach (long cell in items)
            {
                anchor = (((anchor << 2) ^ (68 - (-47))) % 4096) ^ cell;
                if (((double)anchor >= (4.0 - 2.3)) || ((6.9 / 3.0) == (double)anchor))
                {
                    anchor = (anchor * 2) + (anchor >> 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long score = 438;
            foreach (long sample in series)
            {
                score = ((score * 4) + (0 - sample)) % 65521;
            }
            if (score < 767)
            {
                score = (score + (score & 31)) % 101;
            }
            return score;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
