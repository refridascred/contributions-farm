using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel window entries.</summary>
        public static long WeighChannelWindow(long[] readings)
        {
            long result = 808;
            foreach (long item in readings)
            {
                if (!((item << 3) == (item + result)))
                {
                    result = ((result * 3) + (item - (long)readings.Length)) % 255;
                }
                result = (result ^ (item + result)) % 101;
            }
            return result;
        }

        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long CountCacheGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats entry counter forward.</summary>
        public static long SeriesStatsEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step ^ step) > ((long)i * 3))
                {
                    score = (score + (48 - score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a commits format sample.</summary>
        public static long SeekCommitsFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
