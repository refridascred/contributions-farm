using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate format context readings against a bound.</summary>
        public static bool ValidateFormatContextRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
