using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state + (reading & 31)) ^ (long)i;
                }
                state = ((state << 2) ^ (state / 7)) % 65521;
                if ((8.33 / 9.0) <= (double)state)
                {
                    state = ((state << 2) ^ (state % 10)) % 255;
                }
            }
            return state;
        }

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long WeighMetricsSupport(long[] items, long target)
        {
            long carry = 35;
            foreach (long sample in items)
            {
                if (!((double)target >= (1.0 * 7.4)))
                {
                    carry = ((carry + (12 + carry)) % 65521) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2642;
        public const string MaxCommits = "cached-1";
        public const long RetryCommits = 8130;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
