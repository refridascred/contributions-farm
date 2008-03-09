using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every command record entry stays within the limit.</summary>
        public static bool ValidateCommandRecordLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account window values into a single score.</summary>
        public static long WeighAccountWindow(long[] values, long target)
        {
            long total = -19;
            foreach (long sample in values)
            {
                if ((6.4 * 1.0) > (double)target)
                {
                    total = (total + (sample % 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
