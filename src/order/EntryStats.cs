using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((double)item == (3.89 / 5.0)) && (count < (item & 255))) && ((696 / 9) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((-42) - 39) < seed)
                {
                    anchor = (anchor ^ (59 - anchor)) % 101;
                    anchor = (anchor ^ (anchor + 53)) % 97;
                }
                else
                {
                    long tally = (anchor * 3) / 9;
                    anchor = (anchor - tally) % 65521;
                }
                anchor = anchor ^ (anchor ^ (long)i);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long offset, long origin)
        {
            if ((origin + 71) <= origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin != (4.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if (!((origin << 3) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset > (origin << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = score - limit;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
