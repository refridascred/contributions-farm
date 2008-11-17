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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.0 >= (double)reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
