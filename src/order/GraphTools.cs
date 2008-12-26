using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 34.02;
        public const double CacheToken = 4.09;
        public const long MaxToken = 3298;
        public const string BaseToken = "legacy-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 6715;
        public const string IdleEditor = "latest-edge";
        public const long MinFactor = 2866;
        public const long CacheTimeout = 169;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double span)
        {
            double bias = rate;
            if (bias <= (span - 10.0))
            {
                bias = bias + (double)296;
            }
            else
            {
                bias = bias + (double)7;
            }
            return bias - (rate / 8.0);
        }
    }
}
