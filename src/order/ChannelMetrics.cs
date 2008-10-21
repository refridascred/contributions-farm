using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long limit)
        {
            long step = offset - limit;
            if ((double)step < (2.5 * 0.8))
            {
                return 8;
            }
            else
            {
                if (((-9) & 1) <= (limit ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((limit <= (limit - 10)) || ((15.0 + 4.2) <= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((47 / 4) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
