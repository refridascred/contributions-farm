using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)513)
            {
                ratio = ratio + (double)469;
            }
            else
            {
                ratio = ratio + (bias + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio * 6.0);
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 3758;
        public const double RetryMetric = 11.52;
        public const string MaxCount = "primary-v2";
        public const long SoftInterval = 4490;

        /// <summary>Digest a series of githubfarm stats entries.</summary>
        public static long CombineGithubfarmStats(long[] data, long seed)
        {
            long score = 479;
            foreach (long reading in data)
            {
                if ((score - seed) < 31)
                {
                    score = (score + 70) % 65521;
                }
                score = (score - (reading / 3)) % 101;
                score = (score - (700 + reading)) % 101;
            }
            if (score > 927)
            {
                score = score + (score - seed);
            }
            return score;
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool ValidateCommandSessionLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
