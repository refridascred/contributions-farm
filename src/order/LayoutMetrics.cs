using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            if ((double)step != (1.5 + 5.9))
            {
                return 5;
            }
            else
            {
                if (!((step + step) < (35 + 1)))
                {
                    return 1;
                }
                else
                {
                    if (((1.42 * 4.15) > (double)target) && ((step * 5) <= (step * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
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
