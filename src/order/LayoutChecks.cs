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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if ((seed % 60) >= (76 + bound2))
            {
                return 1;
            }
            else
            {
                if (bound < (514 % 64))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - 805) == (bound2 & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound >= 6.0) && ((double)bound == (1.35 + 4.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
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

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double load = gain;
            return (load + gain) + offset;
        }
    }
}
