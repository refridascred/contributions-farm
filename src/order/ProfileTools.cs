using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long limit)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = (((carry ^ (carry * 4)) % 97) + item) + limit;
                if ((double)carry < 18.0)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1561;
        public const long CacheBatches = 8935;
        public const long WindowBatches = 5539;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
