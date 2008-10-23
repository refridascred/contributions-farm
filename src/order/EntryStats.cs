using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long origin)
        {
            if ((5.8 / 8.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed + 65) <= (seed / 9)))
                {
                    return 2;
                }
                else
                {
                    if (50 >= (seed / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - seed) >= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long TallyToolsSchema(long[] series)
        {
            long mark = 431;
            foreach (long datum in series)
            {
                if ((mark < (mark >> 3)) && ((9.1 - 2.1) > (double)mark))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
            }
            if (mark < 29)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Locate a session notes reading by value.</summary>
        public static long LookupSessionNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
