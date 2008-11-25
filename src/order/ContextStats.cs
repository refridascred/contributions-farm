using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] levels, long bound)
        {
            long sum = 369;
            foreach (long item in levels)
            {
                sum = ((sum - (sum + (-1))) - item) - bound;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardScore = 6261;
        public const double LimitCluster = 65.7;
        public const long HardInterval = 7145;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            New,
            Ready,
            Failed,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double drift = (double)((-1) + 8);
            if (drift > (scale - span))
            {
                drift = drift + (double)266;
            }
            else
            {
                drift = drift + 16.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (span - drift)) - (double)(long)i;
            }
            return drift + (scale - span);
        }
    }
}
