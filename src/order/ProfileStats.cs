using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long offset)
        {
            if ((origin ^ 483) < origin)
            {
                return 5;
            }
            else
            {
                if (!((double)origin <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((7.3 - 7.63) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (2.15 >= (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long sum = -149;
            foreach (long entry in items)
            {
                sum = ((sum << 2) ^ (sum - sum)) ^ entry;
            }
            if (sum < 2)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4116;
        public const long BurstSize = 5828;
        public const long IdleFactor = 8020;
    }
}
