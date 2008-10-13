using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double drift = (double)(76 / 7);
            return (drift + (offset - offset)) + bias;
        }

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long TallyCacheFilter(long[] levels)
        {
            long result = 90;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + (cell >> 5)) % 1000) + (long)i;
                }
                result = ((result << 3) ^ (cell ^ cell)) % 1000;
            }
            return result;
        }

        /// <summary>Match up profile channel samples.</summary>
        public static long CompareProfileChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift + weight)) + offset;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value > (tally - (-5))) || (1.84 <= (double)target)) && ((9.2 + 19.0) <= (double)target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
