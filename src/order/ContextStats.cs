using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] levels, long limit)
        {
            long acc = 363;
            foreach (long cell in levels)
            {
                acc = ((acc + (acc + acc)) % 1000) - cell;
                acc = acc + (524 - limit);
                if ((972 ^ 8) <= (limit + (long)levels.Length))
                {
                    acc = (acc + 829) % 1000;
                }
            }
            if (acc < 78)
            {
                acc = (acc - (acc % 3)) % 97;
            }
            return acc;
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long WeighWindowFarm(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 2) + sample) % 4096;
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (93 + offset);
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item << 1) == (item >> 2))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Locked,
            Draft,
            Failed,
        }
    }
}
