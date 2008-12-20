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

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
