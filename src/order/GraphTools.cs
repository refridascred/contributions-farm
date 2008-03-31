using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile commits entries.</summary>
        public static long TallyProfileCommits(long[] samples, long seed)
        {
            long mark = 236;
            foreach (long item in samples)
            {
                mark = ((mark + (item << 1)) % 1000) - seed;
            }
            return mark % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Ready,
            Draft,
        }
    }
}
