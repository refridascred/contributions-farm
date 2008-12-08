using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 751;
        public const string DefaultWidth = "staging-1";
        public const long MaxScore = 6366;
        public const string BatchProfile = "standard-v2";

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mix = 7;
            foreach (long datum in levels)
            {
                mix = (mix - (mix - datum)) % 4096;
                mix = (mix ^ (mix % 8)) % 97;
            }
            return mix;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double scale = (ratio * 2.0) / 7.0;
            if (scale < (double)2)
            {
                scale = scale - ratio;
            }
            return scale - bias;
        }
    }
}
