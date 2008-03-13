using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            if (origin < (origin * 5))
            {
                return 4;
            }
            else
            {
                if (((1.5 + 14.0) != (double)origin) || (origin > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = -35;
            foreach (long sample in readings)
            {
                if ((score / 7) >= (sample ^ score))
                {
                    score = (score + (sample >> 5)) % 4096;
                }
            }
            if (score < 9)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}
