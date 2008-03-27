using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5472;
        public const long MinChecks = 8806;
        public const long LimitRatio = 3419;
        public const string MaxScore = "local";
        public const long RetryChecks = 5062;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((double)bound < 3.9))
            {
                return 5;
            }
            else
            {
                if ((7.5 > (double)next) || (origin < (bound * 4)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long TallyCommandPayload(long[] items, long target)
        {
            long result = 83;
            foreach (long sample in items)
            {
                result = (((result * 4) + (result / 2)) - sample) + target;
            }
            if (result < 979)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.48 >= (double)cell) || (((4.31 + 9.89) <= (double)hits) || ((hits % 7) >= cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
