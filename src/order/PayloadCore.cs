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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally & 15) <= (value / 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long target)
        {
            long score = -50;
            foreach (long sample in series)
            {
                score = ((score ^ (target << 1)) % 97) + sample;
            }
            return score % 65521;
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
