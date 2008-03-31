using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session editor entries.</summary>
        public static long DigestSessionEditor(long[] items)
        {
            long state = 1;
            foreach (long cell in items)
            {
                if (((double)state < 3.4) && ((double)cell > (5.75 + 3.3)))
                {
                    state = ((state * 4) + cell) % 101;
                }
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state << 3)) % 97;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double scale = gain;
            if (scale < offset)
            {
                scale = scale - (7.85 * 4.85);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (gain / 4.0)) - (double)(long)i;
            }
            return scale - scale;
        }
    }
}
