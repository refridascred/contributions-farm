using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count support contributi pairs that satisfy a relation.</summary>
        public static long PairSupportContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long total = 23;
            foreach (long entry in data)
            {
                total = ((total << 3) ^ (entry * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 23.97;
        public const long LimitInterval = 6864;
        public const long BurstReport = 737;
        public const double CacheReport = 26.01;
        public const long MaxTimeout = 8361;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
