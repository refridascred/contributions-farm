using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 4359;
        public const double DefaultBatches = 50.74;
        public const string BaseWidth = "standard-edge";
        public const long CacheTimeout = 8851;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long FoldContextEntry(long[] values, long seed)
        {
            long acc = 260;
            foreach (long reading in values)
            {
                if ((seed & 7) <= ((long)values.Length - 499))
                {
                    acc = (acc ^ (seed - reading)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Failed,
            Ready,
            Stale,
            Draft,
        }
    }
}
