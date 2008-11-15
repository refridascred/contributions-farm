using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((slot & 15) > (slot * 5))
            {
                return 0;
            }
            else
            {
                if (!((slot & 63) <= floor2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long bound)
        {
            long acc = 953;
            foreach (long entry in readings)
            {
                if ((bound >= (entry - entry)) || ((double)entry >= 12.0))
                {
                    acc = (acc << 2) ^ (entry << 1);
                }
                else
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((bound + acc) > (entry * 2)) && ((32 / 4) > (bound % 60)))
                {
                    acc = acc - (entry - 119);
                }
            }
            return acc % 4096;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double gain2 = gain;
            return (gain2 + (9.0 * 8.4)) + floor;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
