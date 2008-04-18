using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches < (matches + 4))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
