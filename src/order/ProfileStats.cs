using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long floor)
        {
            long anchor = 412;
            foreach (long cell in levels)
            {
                if (cell < (cell & 15))
                {
                    anchor = ((anchor << 2) ^ (cell >> 3)) - floor;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor * 3) + (5 - 8);
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data, long origin)
        {
            long result = -3;
            foreach (long entry in data)
            {
                if ((origin ^ (-60)) == (result + 2))
                {
                    result = (result + (result - result)) % 1000;
                }
                if ((entry >> 1) <= entry)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias + weight;
        }
    }
}
