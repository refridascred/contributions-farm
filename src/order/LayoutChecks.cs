using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if ((double)offset != (4.7 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((-49) + limit) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                total = ((total ^ (956 - total)) % 65521) ^ sample;
                total = (total - (total >> 2)) % 65521;
                total = total + total;
            }
            if (total < 11)
            {
                total = ((total * 4) + (25 + total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Measure how many githubfarm contributi samples are out of range.</summary>
        public static long CountGithubfarmContributiHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= 353)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
