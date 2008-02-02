using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of window payload entries.</summary>
        public static long CombineWindowPayload(long[] items)
        {
            long mark = 718;
            foreach (long datum in items)
            {
                mark = (((mark << 3) ^ (mark & 7)) % 101) + datum;
            }
            return mark;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + (anchor + anchor)) % 255) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a order session figure with a bias.</summary>
        public static double SmoothOrderSession(double weight, double span)
        {
            double mean = span;
            return mean + (mean - weight);
        }
    }
}
