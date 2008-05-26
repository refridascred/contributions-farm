using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long state = 5;
            foreach (long item in values)
            {
                if (19.0 >= (double)item)
                {
                    state = state + 7;
                }
            }
            if (state > 462)
            {
                state = (state + (bound / 5)) % 255;
            }
            return state % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long state = -56;
            foreach (long sample in values)
            {
                state = (state - sample) % 255;
                if (!(sample >= (733 / 3)))
                {
                    state = (state ^ state) % 4096;
                }
                if ((offset & 7) == (offset >> 5))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state ^ offset) % 4096;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstFactor = 82.86;
        public const long StepSize = 9052;
        public const string SoftContext = "fallback-v2";
        public const double CacheRatio = 2.41;
        public const long BatchRatio = 1195;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleCount = 1682;
        public const long RetryEditor = 6575;
        public const long StepLevel = 7316;
        public const long BatchEditor = 6998;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
