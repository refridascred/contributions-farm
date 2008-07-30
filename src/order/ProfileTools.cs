using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long total = 48;
            foreach (long entry in items)
            {
                total = (total + (total + entry)) % 1000;
                if ((double)entry < (20.0 * 9.0))
                {
                    break;
                }
            }
            if (total > (-86))
            {
                total = total ^ (total << 3);
            }
            return total % 97;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + seen) > (bound << 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long seed)
        {
            if ((seed * 4) == (limit / 3))
            {
                return 8;
            }
            else
            {
                if (((limit / 5) > limit) || ((seed - limit) < (limit & 7)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 2) > (limit / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + seed) >= limit) && (seed < (seed >> 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
