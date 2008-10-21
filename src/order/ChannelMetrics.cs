using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings)
        {
            long mix = 334;
            foreach (long cell in readings)
            {
                if ((mix & 127) < (cell % 3))
                {
                    mix = mix + (0 + cell);
                }
                else
                {
                    mix = (mix ^ (cell + cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long anchor = 463;
            foreach (long sample in data)
            {
                if ((62 + 611) <= (limit % 64))
                {
                    anchor = ((anchor << 3) ^ anchor) + sample;
                }
                if (anchor < (anchor - anchor))
                {
                    anchor = anchor - limit;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
