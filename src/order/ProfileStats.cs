using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double ratio = (double)((-284) + 904);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (bias2 / 6.0);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Idle,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Combine payload token values into a single score.</summary>
        public static long CombinePayloadToken(long[] levels, long target)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((double)mark < (double)target)
                {
                    mark = ((mark << 2) ^ (168 << 1)) ^ cell;
                }
                else
                {
                    mark = mark ^ (target + mark);
                }
            }
            return mark;
        }
    }
}
