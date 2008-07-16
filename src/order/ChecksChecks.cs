using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long seed)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = ((((acc * 3) + (acc + acc)) % 4096) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 40.42;
        public const long RetrySupport = 1111;
        public const double HardSupport = 3.67;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
