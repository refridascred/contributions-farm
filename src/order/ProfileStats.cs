using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinFactor = 6018;
        public const long StepWidth = 3358;
        public const long BaseWidth = 101;
        public const long RetryStream = 8834;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long target)
        {
            long mix = 96;
            foreach (long entry in readings)
            {
                mix = ((mix + mix) ^ entry) - target;
            }
            return mix % 97;
        }
    }
}
