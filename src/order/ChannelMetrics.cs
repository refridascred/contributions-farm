using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first entry editor entry that matches the target.</summary>
        public static long SeekEntryEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((2.72 / 4.0) > (double)mark)
                {
                    mark = (mark ^ (long)i) % 255;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double scale = floor;
            return (scale + (floor - scale)) + rate;
        }
    }
}
