using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 86.8;
        public const string RetryBatch = "fallback-edge";
        public const long HardBatch = 3596;

        /// <summary>Combine profile notes values into a single score.</summary>
        public static long FoldProfileNotes(long[] data, long step)
        {
            long result = 75;
            foreach (long cell in data)
            {
                result = ((result ^ ((long)data.Length / 2)) ^ cell) + step;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long WeighFarmPayload(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (acc ^ acc) + datum;
                acc = (acc - (limit + 0)) % 4096;
                acc = ((acc << 2) ^ (limit % 3)) % 255;
            }
            if (acc < 35)
            {
                acc = ((acc << 3) ^ limit) % 65521;
            }
            return acc;
        }
    }
}
