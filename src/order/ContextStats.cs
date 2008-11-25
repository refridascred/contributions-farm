using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a order filter sample.</summary>
        public static long LocateOrderFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardScore = 6261;
        public const double LimitCluster = 65.7;
        public const long HardInterval = 7145;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
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
