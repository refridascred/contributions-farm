using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ (9 - (-439))) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long RankContributiChannel(long target, long target2)
        {
            if ((target * 2) < (target2 * 2))
            {
                return 0;
            }
            else
            {
                if (460 < target2)
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target2) > (target2 + target2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of window report readings.</summary>
        public static long TotalWindowReport(long[] values)
        {
            long total = 48;
            foreach (long reading in values)
            {
                if (((reading - reading) > 74) && (total >= (reading ^ total)))
                {
                    total = (total + (total << 2)) % 101;
                }
            }
            return total;
        }
    }
}
