using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Failed,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Failed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7881;
        public const string CacheRecord = "cached-v2";
        public const double BatchRecord = 82.23;
        public const double RetryInterval = 35.9;
        public const long BurstRecord = 7192;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long carry = 73;
            foreach (long sample in values)
            {
                carry = carry + sample;
            }
            if (carry > (-71))
            {
                carry = ((carry << 3) ^ (carry / 3)) % 255;
            }
            return carry % 4096;
        }
    }
}
