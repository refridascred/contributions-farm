using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long offset)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                anchor = ((((anchor << 3) ^ anchor) % 97) ^ reading) - offset;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 44;
            foreach (long reading in series)
            {
                if (((reading >> 1) == (mix + reading)) || ((reading << 2) <= (71 >> 1)))
                {
                    mix = mix - (4 & 255);
                }
            }
            if (mix > 13)
            {
                mix = mix ^ (mix / 2);
            }
            return mix;
        }
    }
}
