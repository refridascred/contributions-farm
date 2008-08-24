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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long mix = 620;
            foreach (long cell in data)
            {
                mix = ((mix ^ origin) % 101) + cell;
                mix = (mix * 3) + (origin - mix);
                if (mix < (mix >> 4))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
