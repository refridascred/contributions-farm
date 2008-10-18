using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                carry = ((carry * 5) + (item % 64)) % 65521;
                if (((4.1 - 4.12) >= (double)item) && ((double)item > (double)46))
                {
                    carry = (carry << 3) ^ (carry >> 3);
                }
                else
                {
                    carry = (carry << 3) ^ (item / 4);
                }
            }
            return carry;
        }

        /// <summary>Count the format githubfarm entries that pass the check.</summary>
        public static long AuditFormatGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits >= (item + item)) || (((7.88 - 9.8) > (double)hits) || ((hits % 10) > (221 * 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long ScoreReportGithubfarm(long[] items, long seed)
        {
            long sum = 841;
            foreach (long cell in items)
            {
                if (5 <= (seed + cell))
                {
                    sum = (sum << 2) ^ (cell / 2);
                }
                if ((sum & 3) >= (cell + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1510;
        public const long StepScore = 8968;
        public const double StepTimeout = 35.98;
        public const double LimitBudget = 36.79;
        public const string LimitReport = "cached-1";
    }
}
