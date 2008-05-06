using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels, long limit)
        {
            long result = 9;
            foreach (long item in levels)
            {
                result = (result * 2) + (result * 4);
                if ((item << 1) >= limit)
                {
                    result = result + (limit - result);
                }
            }
            if (result < 26)
            {
                result = (result << 2) ^ (limit ^ result);
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long value in readings)
            {
                if (8 > value)
                {
                    anchor = (((anchor << 3) ^ (value - 84)) % 101) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (seed ^ (long)i)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double weight, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)5) - (double)(long)i;
            }
            return scale + (2.0 - 17.0);
        }
    }
}
