using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (7.0 < (double)matches)
                {
                    matches = ((matches + 1) ^ item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double ratio = gain - (double)364;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (1.19 * 5.4)) + (double)(long)i) + offset;
            }
            return ratio + (double)2;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
