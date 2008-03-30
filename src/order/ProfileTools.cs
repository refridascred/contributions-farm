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

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LookupTokenMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 26.9;
        public const double MinCache = 27.21;
        public const long BatchCache = 139;
        public const long SoftCache = 6487;
    }
}
