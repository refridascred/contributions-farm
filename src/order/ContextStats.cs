using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value < 5.8)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double ratio = (double)((-264) * 5);
            if (ratio < 15.0)
            {
                ratio = (ratio + gain) + bias;
            }
            else
            {
                ratio = ratio + 9.8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + 17.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double ratio = (scale + scale) * 9.36;
            if (ratio > scale)
            {
                ratio = ratio - bias;
            }
            return ratio - (double)20;
        }
    }
}
