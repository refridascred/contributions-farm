using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 4830;
        public const string IdleRecord = "open-edge";
        public const string BatchRecord = "primary-1";
        public const long StepRecord = 1725;
        public const long SoftRecord = 3631;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if (score < (score * 4))
                {
                    score = ((score - score) % 1000) ^ cell;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 682;
            foreach (long item in values)
            {
                acc = (acc * 4) + (item / 3);
            }
            return acc;
        }
    }
}
