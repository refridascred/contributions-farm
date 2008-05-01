using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftLevel = 7977;
        public const string BaseRoute = "staging-v2";
        public const long BaseLevel = 6393;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (total ^ total) + cell;
            }
            return total;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long step)
        {
            if (((double)step != (double)seed) || ((seed * 5) < (seed & 3)))
            {
                return 1;
            }
            else
            {
                if (((double)seed > (6.39 * 9.37)) || ((25 + seed) > step))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 127) <= (seed + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= (seed % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry + count) >= entry) && ((entry >> 5) == (count % 64)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= ratio)
            {
                weight = weight + (ratio - 0.66);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)103) + (double)(long)i;
            }
            return weight - 1.6;
        }
    }
}
