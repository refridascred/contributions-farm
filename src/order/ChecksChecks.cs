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

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long limit)
        {
            long anchor = 28;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor - (item >> 5)) % 255) - (long)i;
                    anchor = ((anchor * 5) + (item / 9)) % 4096;
                }
                anchor = ((anchor << 2) ^ ((long)data.Length - 287)) % 101;
            }
            if (anchor < 169)
            {
                anchor = anchor - (limit - 6);
            }
            return anchor % 65521;
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
