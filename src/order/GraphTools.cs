using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowBudget = "strict";
        public const string BatchGithubfarm = "standard-v2";
        public const long RetryGithubfarm = 6484;
        public const string StepScore = "strict-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long state = -94;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (state - (long)i) - value;
                    state = ((state << 2) ^ (3 % 16)) % 97;
                }
                state = ((state * 4) + ((long)series.Length - 948)) % 97;
            }
            return state;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double weight = 19.0;
            if (weight <= weight)
            {
                weight = ((weight + (weight * 1.7)) + gain) - floor;
            }
            return weight - (weight + weight);
        }
    }
}
