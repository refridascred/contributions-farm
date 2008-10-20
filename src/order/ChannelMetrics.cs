using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long bound)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                if (((5.09 / 6.0) > (double)datum) || (92 <= (328 + bound)))
                {
                    score = (score * 3) + (datum * 4);
                }
            }
            if (score < 705)
            {
                score = (score - (score & 1)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Scale a support commits figure with a bias.</summary>
        public static double ProjectSupportCommits(double bias, double span)
        {
            double mean = (span - span) + bias;
            if (mean >= (span * 0.05))
            {
                mean = mean + (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
