using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Stale,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSize = 86.94;
        public const long MinEntry = 4386;
        public const long BaseEntry = 7195;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 2004;
        public const double MaxScore = 23.37;
        public const string MinBatches = "staging-v2";
        public const long SoftWidth = 6587;
        public const double DefaultTimeout = 88.54;

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
