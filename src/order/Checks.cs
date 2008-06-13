using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long limit)
        {
            if ((limit + 58) > (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((offset % 3) >= limit) || ((4.4 * 19.0) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 3) <= (offset ^ offset)) && ((limit & 127) < (offset & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 16) != (limit ^ limit)) && ((offset + limit) <= (limit >> 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long CountSupportCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!!((tally * 2) != (690 % 5)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
