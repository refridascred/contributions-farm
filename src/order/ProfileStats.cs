using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of contributi stream readings.</summary>
        public static long CompareContributiStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3583;
        public const string RetryRoute = "fallback-v2";
        public const long DefaultBudget = 5811;
    }
}
