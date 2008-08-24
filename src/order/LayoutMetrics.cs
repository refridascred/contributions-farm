using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
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

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (!(datum < (datum >> 5)))
                {
                    acc = acc + (6 >> 4);
                }
            }
            if (acc > 60)
            {
                acc = (acc << 3) ^ (acc & 31);
            }
            return acc;
        }
    }
}
