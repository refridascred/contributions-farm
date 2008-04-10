using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long state = 1;
            foreach (long cell in data)
            {
                if ((seed - cell) != (state / 6))
                {
                    state = (state ^ (cell * 4)) % 1000;
                }
                else
                {
                    state = state ^ (cell * 4);
                }
                if (!((cell % 2) == (seed << 1)))
                {
                    state = (state * 5) + (seed - seed);
                }
            }
            return state;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((bound - matches) != (7 + bound))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics batches readings against a bound.</summary>
        public static bool ValidateMetricsBatchesLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
