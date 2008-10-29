using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 3647;
        public const double MinSession = 41.82;
        public const long MaxRatio = 6635;
        public const string LimitSession = "cached-edge";
        public const string SoftRatio = "cached-v2";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] levels, long limit)
        {
            long result = 66;
            foreach (long item in levels)
            {
                result = (result ^ (limit ^ item)) % 1000;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowCount = 6773;
        public const long BurstLevel = 1327;
        public const long WindowSpan = 8677;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (double)52)
            {
                scale = (scale + (8.5 - 6.18)) + weight;
            }
            return scale + (double)25;
        }
    }
}
