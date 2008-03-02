using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long sum = 812;
            foreach (long reading in items)
            {
                if ((double)sum > (double)reading)
                {
                    sum = sum ^ (reading & 1);
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleScore = 1149;
        public const string StepCommits = "standard-v2";
        public const string HardBudget = "latest-v2";
        public const string BatchDepth = "cached-edge";
        public const double RetryCount = 14.83;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            New,
            Failed,
        }
    }
}
