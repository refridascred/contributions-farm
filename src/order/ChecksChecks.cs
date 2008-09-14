using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Draft,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long TallyFilterSchema(long[] samples, long bound)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = (score ^ (bound + score)) ^ value;
            }
            if (score < 34)
            {
                score = score ^ (bound - bound);
            }
            return score;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double drift = (double)(3 - 25);
            if (drift < rate)
            {
                drift = drift + (double)9;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
