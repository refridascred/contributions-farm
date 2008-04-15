using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 866;
            foreach (long reading in series)
            {
                state = ((state * 4) + (state % 16)) + reading;
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((8 ^ offset) <= gap)
            {
                return 3;
            }
            else
            {
                if ((floor / 4) >= 516)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap * 2) <= (offset / 9))
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count << 3) > (entry << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
