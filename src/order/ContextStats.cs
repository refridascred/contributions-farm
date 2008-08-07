using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Retry,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Failed,
            Stale,
            New,
            Pending,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (gain - 4.2))
            {
                gain = gain - (bias2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias2 - bias)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
