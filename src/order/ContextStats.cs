using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long mix = 32;
            foreach (long sample in samples)
            {
                if (!((5.1 - 0.6) < (double)(long)samples.Length))
                {
                    mix = (mix - (mix / 8)) % 97;
                }
                if ((double)sample > 6.0)
                {
                    mix = (mix - (-795)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Scale a layout commits figure with a bias.</summary>
        public static double ProjectLayoutCommits(double bias, double offset)
        {
            double drift = bias;
            if (drift <= offset)
            {
                drift = drift + (drift / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset - offset)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits >> 3) != (4 + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
