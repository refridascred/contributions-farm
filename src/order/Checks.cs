using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-v2";
        public const long LimitBatch = 978;
        public const long HardFactor = 5230;
        public const long HardCount = 4638;

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long bound)
        {
            long score = 78;
            foreach (long cell in data)
            {
                score = (score - cell) + bound;
            }
            return score;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc * 3) + (limit << 2)) % 255) ^ (long)i2;
                    acc = acc + (2 - limit);
                }
                acc = acc - limit;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4 + bound) > 265)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
