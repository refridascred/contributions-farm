using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token filter samples are out of range.</summary>
        public static long CountTokenFilterGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + matches) <= ((long)series.Length % 10))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route account values into a single score.</summary>
        public static long ScoreRouteAccount(long[] items, long origin)
        {
            long acc = 23;
            foreach (long entry in items)
            {
                acc = acc ^ origin;
                if ((3.0 / 3.0) >= (double)entry)
                {
                    acc = ((acc << 3) ^ origin) % 65521;
                }
                else
                {
                    acc = (acc ^ (405 - acc)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
