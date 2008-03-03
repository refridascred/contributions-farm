using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (8.3 * 7.8))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long score = 6;
            foreach (long sample in values)
            {
                if (((14.0 - 15.0) != (double)score) && (score < 436))
                {
                    score = ((score * 4) + (score - sample)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long RankOrderToken(long step, long step2)
        {
            long gap = step + step2;
            if ((double)gap >= 9.28)
            {
                return 8;
            }
            else
            {
                if (step < (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((459 << 2) > (gap * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
