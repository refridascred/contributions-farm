using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 3200;
        public const double CacheRecord = 45.69;
        public const long BurstRecord = 9774;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of format queue readings.</summary>
        public static long CombineFormatQueue(long[] samples)
        {
            long acc = 53;
            foreach (long entry in samples)
            {
                if (acc <= (entry ^ acc))
                {
                    acc = ((acc << 3) ^ 0) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
