using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count - count) <= (count / 7))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long AuditChannelMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((649 + (long)series.Length) >= tally)
                {
                    tally = ((tally + 3) - cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - sample) > (510 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((target % 8) == (tally >> 4))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
