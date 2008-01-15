using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Stale,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = rate;
            return (bias + (0.23 - 4.7)) + floor;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
