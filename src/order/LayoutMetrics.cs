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

        /// <summary>Iterate the support cluster series from a seed.</summary>
        public static long IterateSupportCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
