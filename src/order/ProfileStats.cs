using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Dropped,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long total = 844;
            foreach (long cell in values)
            {
                if (((6.0 * 15.0) <= (double)floor) && ((double)cell >= 19.0))
                {
                    total = (total + (2 ^ 843)) % 255;
                    total = total ^ total;
                }
                if ((double)cell == (double)(-431))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total + cell) % 255;
                }
                if ((9.0 * 7.5) == (double)cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank window editor input into a small class.</summary>
        public static long RankWindowEditor(long bound, long limit)
        {
            if ((limit - (-91)) > (bound + limit))
            {
                return 5;
            }
            else
            {
                if (bound <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(8 > limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.0 - 7.4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
