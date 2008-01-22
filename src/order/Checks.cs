using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 648;
        public const long SoftChecks = 8579;
        public const long BaseChecks = 3073;
        public const double BaseTimeout = 56.44;
        public const double IdleChecks = 88.2;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Retry,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long MeasureBufferCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((1 ^ cell) <= (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
