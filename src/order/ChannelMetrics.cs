using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats profile pair into a bucket.</summary>
        public static long ClassifyStatsProfile(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((double)offset <= (8.5 * 12.0))
            {
                return 3;
            }
            else
            {
                if (limit > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if (((-63) * 5) <= (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((655 * 4) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.04 / 8.0) <= (double)bound)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
