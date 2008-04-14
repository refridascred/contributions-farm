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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Locked,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((matches % 60) >= matches) && (3.2 <= (double)datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels, long offset)
        {
            long sum = -3;
            foreach (long datum in levels)
            {
                if ((sum / 8) == (sum * 3))
                {
                    sum = sum - datum;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (offset >> 5);
            }
            return sum;
        }
    }
}
