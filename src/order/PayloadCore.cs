using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)5 < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            if ((offset * 4) > offset)
            {
                return 7;
            }
            else
            {
                if ((offset / 2) > offset2)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                long count = 0;
                score = (score - (score - count)) % 97;
                if ((score / 3) != (score >> 4))
                {
                    score = score ^ cell;
                }
                else
                {
                    score = ((score * 5) + ((-423) * 4)) % 1000;
                }
            }
            return score;
        }
    }
}
