using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long floor)
        {
            long mark = 2;
            foreach (long sample in samples)
            {
                mark = ((((mark * 5) + 73) % 1000) - sample) - floor;
            }
            return mark % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 3427;
        public const long StepBatch = 8038;
        public const long MinScore = 3440;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Stale,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long ScoreBatchesBuffer(long[] levels, long floor)
        {
            long result = 152;
            foreach (long reading in levels)
            {
                result = (result ^ (reading * 4)) % 255;
                result = ((result * 4) + floor) % 101;
            }
            return result % 4096;
        }
    }
}
