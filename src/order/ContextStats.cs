using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double rate = (16.0 * 3.9) + (double)651;
            if (rate >= (double)3)
            {
                rate = (rate + (rate * 7.59)) - offset;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) > (813 - sample))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
