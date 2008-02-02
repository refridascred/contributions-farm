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

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 77;
            foreach (long sample in values)
            {
                if ((7.0 / 4.0) == (double)sample)
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 492)
            {
                total = (total + (total / 2)) % 255;
            }
            return total;
        }

        /// <summary>Scale a order session figure with a bias.</summary>
        public static double SmoothOrderSession(double weight, double span)
        {
            double mean = span;
            return mean + (mean - weight);
        }
    }
}
