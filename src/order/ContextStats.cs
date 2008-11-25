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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = (acc ^ (acc / 3)) % 255;
                acc = ((acc * 3) + acc) % 4096;
                if ((datum < (acc - acc)) || ((datum / 4) <= (5 + acc)))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
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
