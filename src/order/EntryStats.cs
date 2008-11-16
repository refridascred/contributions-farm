using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long acc = 359;
            foreach (long sample in data)
            {
                if (((double)sample != (3.0 / 5.0)) || ((0 - 6) > (sample ^ acc)))
                {
                    acc = ((acc << 2) ^ (sample / 9)) % 97;
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 5467;
        public const long RetrySpan = 4841;
        public const double MaxEntry = 1.22;
        public const long LimitBudget = 1097;

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 50.92;
        public const long WindowSpan = 476;
        public const double SoftSupport = 63.25;
        public const long BatchSupport = 1887;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long offset)
        {
            long state = 268;
            foreach (long sample in items)
            {
                if ((500 % 24) > (offset - state))
                {
                    state = (((state << 3) ^ offset) % 101) - sample;
                }
            }
            if (state > 67)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(count >= (16 + value)))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
