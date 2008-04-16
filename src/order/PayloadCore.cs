using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long offset)
        {
            if (origin <= (offset + origin))
            {
                return 4;
            }
            else
            {
                if (((double)54 > (double)offset) && ((origin << 2) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset <= (7.8 * 2.5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long ScoreQueueWindow(long[] data, long target)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = ((anchor << 2) ^ (entry / 9)) - target;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item * 4) <= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
