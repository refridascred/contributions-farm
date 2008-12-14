using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches * 2) == (matches % 97)))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((3.0 + 1.78) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long GradeRouteChecks(long target, long bound)
        {
            long gap = target + bound;
            if (((target + target) == (gap - bound)) || ((double)target == (13.0 / 6.0)))
            {
                return 7;
            }
            else
            {
                if ((gap >> 1) == (bound + bound))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            long diff = offset ^ target;
            if ((diff / 6) < diff)
            {
                return 1;
            }
            else
            {
                if (diff < ((-7) + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.46 / 8.0) <= (7.0 * 8.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
