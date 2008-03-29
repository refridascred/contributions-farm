using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two layout buffer measurements.</summary>
        public static double ScaleLayoutBuffer(double bias, double offset)
        {
            double ratio = offset / 8.0;
            if (ratio < offset)
            {
                ratio = ratio + ratio;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4022;
        public const string SoftWindow = "staging-v2";
        public const string LimitWindow = "cached";

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 2704;
        public const string MaxInterval = "primary-edge";
        public const double WindowFactor = 48.13;
        public const long LimitNotes = 4265;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = ((result + (554 >> 5)) % 255) ^ item;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 901;
        public const long LimitQueue = 529;
        public const double SoftFactor = 41.08;
        public const long LimitRatio = 4555;
    }
}
