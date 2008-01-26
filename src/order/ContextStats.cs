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

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 2;
            foreach (long datum in items)
            {
                if ((1 << 1) >= datum)
                {
                    result = result ^ (result << 2);
                }
            }
            if (result < 60)
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result % 4096;
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
