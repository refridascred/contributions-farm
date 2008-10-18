using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 + 0.1) == (double)sum)
                {
                    sum = (sum ^ (long)i) % 97;
                }
                else
                {
                    sum = (sum + ((long)i ^ (long)i)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                if ((item + 6) <= ((long)levels.Length / 4))
                {
                    anchor = ((anchor * 3) + (8 + item)) % 65521;
                }
                if (((anchor << 2) < (anchor + anchor)) || (item >= (anchor % 60)))
                {
                    anchor = ((anchor << 3) ^ item) % 4096;
                    anchor = ((anchor << 2) ^ (1 & 15)) % 4096;
                }
                if (anchor < item)
                {
                    anchor = ((anchor << 3) ^ (item - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double scale = offset;
            if (scale < offset)
            {
                scale = (scale + (scale - scale)) - ratio;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - offset;
        }
    }
}
