using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 39;
            foreach (long sample in values)
            {
                score = (score * 3) + (sample / 9);
                if ((sample + score) < (score >> 2))
                {
                    score = ((score << 3) ^ (score + sample)) % 1000;
                }
            }
            if (score > 16)
            {
                score = score - (score & 7);
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((target - hits) > (entry * 5)) || !((6.96 + 4.0) >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long AuditStatsClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches - datum) >= (datum ^ datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
