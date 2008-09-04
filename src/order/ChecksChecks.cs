using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3544;
        public const string LimitEntry = "open-v2";
        public const string StepFactor = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 903;
        public const long BurstBatch = 1826;
        public const long HardInterval = 920;
        public const long StepWidth = 8788;
        public const long DefaultRatio = 8313;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long offset)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if (((double)offset >= 1.53) && ((double)offset >= (8.5 * 5.53)))
                {
                    total = ((total << 2) ^ offset) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
