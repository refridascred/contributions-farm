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

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long FoldBufferQueue(long[] samples)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    long slot = reading + 29;
                    acc = acc ^ ((long)i + slot);
                }
                acc = (acc << 3) ^ acc;
                if ((acc * 3) < (5 * 5))
                {
                    break;
                }
            }
            if (acc > 197)
            {
                acc = acc ^ acc;
            }
            return acc;
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
