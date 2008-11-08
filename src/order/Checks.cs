using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double drift = 9.7;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate + 10.0)) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Done,
            Stale,
            Pending,
            New,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Active,
            Ready,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - (-18)) > (origin % 7))
                {
                    mark = ((mark * 4) + origin) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
