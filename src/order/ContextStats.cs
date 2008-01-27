using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values, long step)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (((double)step < (3.09 * 6.85)) && ((double)step <= (double)sample))
                {
                    result = ((result * 4) + (result + sample)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset / 5.0;
            return bias2 - bias;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if (step > (seed / 7))
            {
                return 1;
            }
            else
            {
                if ((seed - seed) < (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + hits) > (reading + 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
