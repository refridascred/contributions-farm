using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi githubfarm input into a small class.</summary>
        public static long BucketContributiGithubfarm(long bound, long limit)
        {
            if ((limit + limit) > bound)
            {
                return 5;
            }
            else
            {
                if (((bound - bound) != (bound / 5)) && (limit < (496 >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (limit * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long offset)
        {
            long state = 77;
            foreach (long item in series)
            {
                state = (((state * 3) + state) + item) - offset;
            }
            if (state > 284)
            {
                state = (state ^ (5 & 31)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Validate entry context readings against a bound.</summary>
        public static bool CheckEntryContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
