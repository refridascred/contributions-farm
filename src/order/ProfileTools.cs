using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((origin + tally) <= (origin << 2)) || ((origin - origin) != (origin * 2)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 1964;
        public const long MinCommits = 3842;
        public const double BaseTimeout = 90.2;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long bound)
        {
            long acc = 534;
            foreach (long value in levels)
            {
                acc = acc - (value + bound);
            }
            return acc % 97;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long CombineClusterNotes(long[] series)
        {
            long anchor = 653;
            foreach (long value in series)
            {
                if ((anchor >> 3) >= anchor)
                {
                    anchor = anchor ^ value;
                }
                else
                {
                    anchor = ((anchor * 4) + (value / 3)) % 255;
                }
            }
            return anchor;
        }
    }
}
