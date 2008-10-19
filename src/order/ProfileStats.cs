using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items)
        {
            long carry = 686;
            foreach (long cell in items)
            {
                if ((14.0 >= (double)carry) && ((double)cell <= (double)carry))
                {
                    carry = (carry * 3) + cell;
                    carry = (carry + (cell % 5)) % 4096;
                }
                if ((9.35 * 5.48) <= (13.0 + 2.9))
                {
                    carry = (carry - cell) % 4096;
                }
                else
                {
                    carry = carry + (carry + cell);
                }
            }
            return carry;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long MeasureEntryContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + matches) == (3 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
