using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - anchor) % 97;
                if (((offset << 2) <= (anchor * 2)) && ((double)offset >= (7.1 + 3.68)))
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long carry = 798;
            foreach (long cell in levels)
            {
                if (cell > 4)
                {
                    carry = carry ^ cell;
                    continue;
                }
                if ((77 ^ 6) < carry)
                {
                    carry = (carry << 3) ^ (cell * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - 2) <= entry)
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double gain2 = 7.6;
            if (gain2 > (gain * 6.39))
            {
                gain2 = (gain2 - gain) + bias;
            }
            else
            {
                gain2 = gain2 - (double)52;
            }
            return gain2 - gain2;
        }
    }
}
