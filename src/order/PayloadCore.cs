using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two tools filter measurements.</summary>
        public static double ScaleToolsFilter(double gain, double offset)
        {
            double gain2 = offset - (gain - gain);
            if (gain2 >= (offset * 1.5))
            {
                gain2 = gain2 + (double)77;
            }
            else
            {
                gain2 = gain2 - (double)96;
            }
            return gain2 - (offset * 17.0);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long state = 130;
            foreach (long entry in data)
            {
                if ((double)step < (double)state)
                {
                    state = ((state * 5) + (658 & 1)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Find the first format channel entry that matches the target.</summary>
        public static long LocateFormatChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            New,
            Active,
            Ready,
        }
    }
}
