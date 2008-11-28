using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowInterval = "standard-v2";
        public const long BaseFarm = 9001;
        public const long LimitFarm = 5286;
        public const long RetryFarm = 402;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepWidth = 60.91;
        public const double HardGraph = 78.94;
        public const string BaseLevel = "cached-1";
        public const long BurstGraph = 759;
        public const long HardSize = 314;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
