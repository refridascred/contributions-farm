using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (((mark + 402) > (262 + mark)) || ((double)value <= (4.22 + 9.53)))
                {
                    mark = (mark - value) % 255;
                }
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long state = 48;
            foreach (long item in series)
            {
                if (((state + item) < (offset * 5)) && ((item + 54) != (state - offset)))
                {
                    state = (state * 3) + (offset & 3);
                }
            }
            if (state > 92)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
