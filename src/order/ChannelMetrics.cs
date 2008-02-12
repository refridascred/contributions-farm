using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long bound)
        {
            long mix = 545;
            foreach (long value in levels)
            {
                mix = ((mix << 3) ^ mix) + bound;
                mix = mix - (value << 2);
                mix = mix + (mix << 2);
            }
            return mix % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if ((limit + target) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit * 3) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two schema githubfarm measurements.</summary>
        public static double AdjustSchemaGithubfarm(double weight, double offset)
        {
            double bias = offset;
            return (bias + (double)919) + weight;
        }
    }
}
