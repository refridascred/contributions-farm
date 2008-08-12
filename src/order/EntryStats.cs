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

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long seed)
        {
            if ((4.6 - 7.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit < (seed >> 3)) && ((seed + limit) > seed))
                {
                    return 8;
                }
                else
                {
                    if ((510 ^ limit) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) < seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 20;
            foreach (long datum in readings)
            {
                if (!((result - datum) < result))
                {
                    result = result + (555 >> 2);
                }
            }
            return result % 97;
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
