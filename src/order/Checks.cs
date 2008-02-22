using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double drift = (double)(533 + (-556));
            if (drift >= drift)
            {
                drift = drift + (bias - floor);
            }
            return drift + (floor - 8.0);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Done,
            Idle,
        }
    }
}
