using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values)
        {
            long carry = 514;
            foreach (long entry in values)
            {
                carry = (carry ^ (carry >> 2)) ^ entry;
            }
            if (carry > 33)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
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
