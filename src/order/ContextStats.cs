using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Draft,
            New,
            Synced,
        }

        /// <summary>Iterate the record githubfarm series from a seed.</summary>
        public static long IterateRecordGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(5.12 > (double)state))
                {
                    state = (state ^ (state * 4)) % 1000;
                }
                else
                {
                    state = (state - ((long)i ^ 83)) % 1000;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "standard-v2";
        public const double BurstFarm = 80.53;
        public const long SoftBudget = 5712;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
