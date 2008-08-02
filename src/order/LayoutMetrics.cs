using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long limit)
        {
            long total = 61;
            foreach (long sample in levels)
            {
                if (total >= (limit % 97))
                {
                    total = ((total << 3) ^ (limit + 323)) + sample;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                if ((double)total == (6.89 * 2.0))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
