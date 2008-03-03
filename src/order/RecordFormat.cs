using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string StepScore = "open-edge";
        public const string HardFormat = "staging-v2";
        public const long HardRatio = 3491;
        public const long DefaultScore = 7438;
        public const double HardFactor = 84.7;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Pending,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally % 97) >= (sample & 255)) || ((sample & 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            New,
            Closed,
        }
    }
}
