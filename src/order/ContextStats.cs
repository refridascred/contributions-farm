using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double offset)
        {
            double weight = (scale * 10.0) + (double)27;
            return (weight - (double)39) + offset;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)limit > (double)anchor)
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits farm entries.</summary>
        public static long WeighCommitsFarm(long[] series, long limit)
        {
            long result = -823;
            foreach (long entry in series)
            {
                if (0.8 >= (double)limit)
                {
                    result = (((result << 3) ^ (limit % 64)) % 4096) + entry;
                }
            }
            return result;
        }
    }
}
