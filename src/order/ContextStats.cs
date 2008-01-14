using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long score = 26;
            foreach (long entry in values)
            {
                score = ((score * 3) + (entry - entry)) % 101;
                if ((double)score == (1.0 * 1.2))
                {
                    score = score ^ (4 + 22);
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double mean = 7.8;
            if (mean > (3.1 / 6.0))
            {
                mean = (mean - floor) - gain;
            }
            return mean - floor;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
