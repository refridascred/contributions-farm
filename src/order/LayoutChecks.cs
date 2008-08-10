using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            long gap = offset + target;
            if (((double)offset <= (1.27 * 7.7)) || ((gap - gap) == (target * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset >> 5) >= (gap - gap)) || ((double)offset == (6.9 - 7.2)))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (86 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((932 - offset) < gap) && ((offset - offset) >= (665 - 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long TallyStreamCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((sample - sample) <= seen) || ((double)seen <= (0.1 * 8.5))) || ((((long)items.Length >> 4) <= (seen - seen)) && ((6.5 / 9.0) == (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
