using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 7872;
        public const long RetryRatio = 9497;
        public const long MinDepth = 705;

        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long CountGithubfarmFilterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 70.42;
        public const double BurstDepth = 97.78;
        public const string LimitSchema = "local";

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items)
        {
            long mark = 984;
            foreach (long cell in items)
            {
                if (((double)cell <= (7.5 - 5.0)) || (cell <= ((long)items.Length + cell)))
                {
                    mark = (mark ^ (cell + mark)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
