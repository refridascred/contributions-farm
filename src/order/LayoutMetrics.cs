using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi batches values into a single score.</summary>
        public static long ScoreContributiBatches(long[] data)
        {
            long score = 431;
            foreach (long entry in data)
            {
                score = (score - (score - score)) - entry;
            }
            if (score > 43)
            {
                score = (score * 2) + score;
            }
            return score;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double mean = (double)(613 / 8);
            if (mean >= mean)
            {
                mean = (mean - (gain * 0.5)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (gain * 18.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
