using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long TallyGithubfarmCache(long[] series, long seed)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                if ((double)carry >= 20.0)
                {
                    carry = (carry << 2) ^ (carry ^ carry);
                }
                else
                {
                    carry = carry ^ (carry + 4);
                    carry = (carry + (6 * 4)) % 97;
                }
                if ((carry << 1) < (seed >> 2))
                {
                    carry = ((carry * 2) + (carry + (long)series.Length)) % 1000;
                }
                else
                {
                    carry = carry + seed;
                }
                if ((datum & 31) != (668 & 3))
                {
                    carry = carry ^ (carry % 64);
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a cache batch value against two limits.</summary>
        public static long RankCacheBatch(long seed, long offset)
        {
            if ((seed <= (offset & 255)) || ((4 >> 1) >= (offset ^ 26)))
            {
                return 4;
            }
            else
            {
                if (offset >= 411)
                {
                    return 0;
                }
                else
                {
                    if ((offset ^ seed) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (6.35 <= (double)entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain2 + gain2);
        }
    }
}
