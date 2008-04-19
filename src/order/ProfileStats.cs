using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell % 24) != (cell - cell))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long score = 41;
            foreach (long value in items)
            {
                if (((double)score >= 20.0) && ((double)limit <= (5.9 + 4.8)))
                {
                    score = (score * 2) + (score << 2);
                }
                if ((double)value <= (5.11 / 4.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long DigestBufferContributi(long[] readings, long target)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum << 2) > (datum % 2))
                {
                    sum = (sum ^ 7) % 101;
                }
                else
                {
                    sum = sum - (target + datum);
                }
            }
            if (sum > 4)
            {
                sum = (sum - target) % 255;
            }
            return sum % 1000;
        }
    }
}
