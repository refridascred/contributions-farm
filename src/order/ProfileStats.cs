using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if (((step * 3) <= (168 * 5)) || (331 < limit))
            {
                return 4;
            }
            else
            {
                if (step < (10 + limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 7311;
        public const long WindowCommits = 5251;
        public const long MaxBudget = 4718;
    }
}
