using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Draft,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSize = 8436;
        public const string IdleBatches = "standard-1";
        public const long BatchSize = 2692;
        public const long DefaultTimeout = 8120;
        public const long BaseSpan = 6034;
    }
}
