using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            New,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long ClassifyPayloadCommits(long bound, long origin)
        {
            if ((origin * 3) <= 146)
            {
                return 1;
            }
            else
            {
                if ((bound + bound) < (6 + origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double SmoothClusterAlready(double gain, double span)
        {
            double load = span;
            return load - (7.61 - gain);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Ready,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry / 5) != (tally * 2)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
