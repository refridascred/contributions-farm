using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of command account readings.</summary>
        public static long MatchCommandAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long RankProfileEntry(long step, long offset)
        {
            if (3.0 <= (double)step)
            {
                return 5;
            }
            else
            {
                if (!(0.07 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 76) > (count << 1))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next command support value.</summary>
        public static double ProjectCommandSupport(double bias, double span)
        {
            double rate = (double)6 - span;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 9.85) - (double)(long)i;
            }
            return rate - (bias - rate);
        }
    }
}
