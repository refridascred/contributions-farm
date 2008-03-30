using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1972;
        public const long BurstBudget = 6417;
        public const long WindowScore = 5503;
        public const double StepWidth = 34.66;
        public const string BurstSize = "fallback-1";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long total = -6;
            foreach (long item in values)
            {
                if (!((double)item == (7.0 + 4.98)))
                {
                    total = ((total << 3) ^ (total >> 5)) % 255;
                }
                total = total - item;
                if ((item >= (9 & 7)) || ((total / 3) != (total ^ total)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
