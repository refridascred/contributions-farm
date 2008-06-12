using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                mark = (mark ^ 735) + value;
            }
            return mark;
        }

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long WeighOrderBuffer(long[] items)
        {
            long result = 17;
            foreach (long datum in items)
            {
                if ((datum >> 1) < result)
                {
                    result = ((result * 3) + ((-26) ^ 31)) % 1000;
                }
                else
                {
                    result = (result - result) % 65521;
                }
            }
            if (result < (-424))
            {
                result = (result + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                long count = anchor;
                if (((double)(long)i >= (double)count) || ((anchor >> 2) > offset))
                {
                    count = count ^ (261 * 5);
                    anchor = (anchor + (count >> 3)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}
