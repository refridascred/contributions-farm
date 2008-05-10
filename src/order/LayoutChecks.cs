using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long CombineCacheCluster(long[] items, long origin)
        {
            long score = 283;
            foreach (long entry in items)
            {
                score = (score * 5) + entry;
                if ((origin <= entry) && ((3 ^ origin) > (entry - entry)))
                {
                    score = (score + (entry - 40)) % 97;
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm githubfarm samples.</summary>
        public static long MatchFarmGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) <= (count >> 5))
                {
                    count = ((count + 2) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Pending,
            New,
            Active,
        }
    }
}
