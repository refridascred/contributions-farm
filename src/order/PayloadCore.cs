using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Ready,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long DigestClusterChecks(long[] series)
        {
            long carry = 83;
            foreach (long entry in series)
            {
                if (carry <= (entry + carry))
                {
                    carry = ((carry * 4) + (entry + 61)) % 97;
                }
                else
                {
                    carry = carry - (carry - entry);
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 4) + (2 + carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool ValidateReportAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long origin)
        {
            if (bound < (origin * 4))
            {
                return 2;
            }
            else
            {
                if (((bound * 4) < (bound / 2)) && ((double)origin >= (double)697))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
