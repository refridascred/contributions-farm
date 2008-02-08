using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long floor)
        {
            if ((double)75 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((seed - floor) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (!((floor % 2) > seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((floor - reading) <= (floor - 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long TallyEditorToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 3.4) != (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
