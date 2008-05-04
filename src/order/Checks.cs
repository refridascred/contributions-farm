using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9800;
        public const long WindowBatches = 73;
        public const long RetryBatches = 6871;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5448;
        public const string StepDepth = "local-v2";
        public const long MaxBatch = 8349;
        public const long LimitBatch = 143;

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix - ((long)i * 5);
                }
                if (value > mix)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long seed)
        {
            long state = 339;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ sample) + seed;
            }
            return state;
        }
    }
}
