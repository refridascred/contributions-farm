using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] values)
        {
            long mix = 71;
            foreach (long cell in values)
            {
                if ((((-645) / 4) < (mix + mix)) || ((cell >> 2) < mix))
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = (mix ^ (cell % 7)) % 255;
                }
                if (cell > (cell + mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
