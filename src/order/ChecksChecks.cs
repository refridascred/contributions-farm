using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue entry input into a small class.</summary>
        public static long RankQueueEntry(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((double)origin <= (3.6 / 7.0))
            {
                return 8;
            }
            else
            {
                if (51 > origin2)
                {
                    return 4;
                }
                else
                {
                    if (!((origin - diff) <= (origin2 + diff)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff % 60) >= (origin >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (7.82 > (double)(long)i)
                {
                    anchor = (anchor * 3) + bound;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
