using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((6.25 + 3.66) >= (double)anchor) || (((long)i & 3) <= anchor))
                {
                    anchor = (anchor - (anchor / 2)) % 101;
                }
                anchor = (anchor * 4) + ((long)i * 2);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a token buffer sample.</summary>
        public static long LocateTokenBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "stable-v2";
        public const long HardQueue = 4808;
        public const long MaxWidth = 9147;
        public const long MaxQueue = 7419;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (mean - mean))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias2 - mean);
            }
            return mean - 7.6;
        }

        /// <summary>Roll a notes farm counter forward.</summary>
        public static long DeriveNotesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (64 - acc)) % 65521;
                acc = ((acc << 2) ^ (acc * 2)) % 255;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
