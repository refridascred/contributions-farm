using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes checks figure with a bias.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double mean = 5.01;
            if (mean >= (double)48)
            {
                mean = (mean + (mean / 5.0)) + offset;
            }
            else
            {
                mean = mean + (double)673;
            }
            return mean + (mean - scale);
        }

        /// <summary>Match up queue cluster samples.</summary>
        public static long MatchQueueClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next account profile value.</summary>
        public static double ProjectAccountProfile(double rate, double bias)
        {
            double scale = bias;
            if (scale < (double)6)
            {
                scale = (scale + bias) - rate;
            }
            return scale - 5.0;
        }
    }
}
