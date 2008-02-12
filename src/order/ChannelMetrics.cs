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

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 7907;
        public const double CacheFactor = 61.24;
        public const string DefaultInterval = "legacy";
        public const long HardRatio = 8048;

        /// <summary>Blend two schema githubfarm measurements.</summary>
        public static double AdjustSchemaGithubfarm(double weight, double offset)
        {
            double bias = offset;
            return (bias + (double)919) + weight;
        }
    }
}
