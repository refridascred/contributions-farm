using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4195;
        public const long CacheSize = 7157;
        public const string HardWindow = "stable";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 78.41;
        public const long BurstBuffer = 242;
        public const double IdleBuffer = 30.71;
        public const string HardBuffer = "latest-v2";
        public const double CacheBuffer = 73.75;

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double bias = gain;
            if (bias <= floor)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (double)9;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long value in levels)
            {
                if ((double)acc >= 9.7)
                {
                    acc = acc ^ ((long)levels.Length + origin);
                }
                else
                {
                    acc = acc - (acc ^ value);
                }
            }
            if (acc < 515)
            {
                acc = acc ^ origin;
            }
            return acc;
        }
    }
}
