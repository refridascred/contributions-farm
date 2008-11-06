using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheWidth = "stable-1";
        public const string SoftTools = "standard-edge";
        public const string IdleWidth = "alpha-edge";

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample * 2) > 325) || ((seen + seen) <= 550))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 69;
            foreach (long cell in data)
            {
                if ((cell << 2) <= (cell ^ cell))
                {
                    mark = (mark ^ (mark >> 2)) % 101;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (mark % 24)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (matches << 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
