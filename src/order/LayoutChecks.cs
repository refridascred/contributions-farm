using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits stats readings.</summary>
        public static long PairCommitsStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long anchor = 130;
            foreach (long cell in values)
            {
                anchor = (((anchor * 4) + anchor) % 4096) ^ cell;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long offset)
        {
            long diff = seed ^ offset;
            if ((double)offset > (double)seed)
            {
                return 5;
            }
            else
            {
                if (diff >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)diff <= (14.0 / 6.0)) && ((offset + diff) > (offset % 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset * 5) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Closed,
            Paused,
            Done,
            Failed,
        }
    }
}
