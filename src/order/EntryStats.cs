using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long AuditStatsRecordMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((-5) / 4) < (value / 5)) && ((double)value != (double)hits))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long carry = 83;
            foreach (long reading in levels)
            {
                if (1.94 >= (double)carry)
                {
                    carry = ((carry << 2) ^ reading) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            New,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 180;
            foreach (long entry in readings)
            {
                if ((score << 2) == (entry - entry))
                {
                    score = ((score * 3) + 9) % 101;
                }
                else
                {
                    score = (score * 5) + (score >> 3);
                }
            }
            return score;
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
