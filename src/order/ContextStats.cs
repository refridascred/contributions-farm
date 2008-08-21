using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double mean = (bias - 5.62) * 1.0;
            if (mean >= (double)9)
            {
                mean = mean + (mean + mean);
            }
            return mean - ratio;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ ((long)i - seed)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] values, long origin)
        {
            long anchor = 18;
            foreach (long datum in values)
            {
                if ((280 * 3) > (origin << 2))
                {
                    anchor = ((anchor - (anchor / 6)) % 101) - datum;
                }
            }
            if (anchor > 843)
            {
                anchor = anchor - origin;
            }
            return anchor % 1000;
        }
    }
}
