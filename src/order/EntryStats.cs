using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long DigestEditorStats(long[] items)
        {
            long carry = 44;
            foreach (long entry in items)
            {
                if ((entry + 849) < (924 - entry))
                {
                    carry = carry - entry;
                }
                else
                {
                    carry = (carry + ((-844) / 2)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 5019;
        public const double LimitSession = 76.43;
        public const string IdleDepth = "cached-v2";
        public const double BaseSession = 57.06;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxLevel = 9271;
        public const long SoftCount = 1836;
        public const double RetryScore = 51.96;
        public const long BurstScore = 2251;
    }
}
