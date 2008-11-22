using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue entry input into a small class.</summary>
        public static long RankQueueEntry(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((double)origin <= (3.6 / 7.0))
            {
                return 8;
            }
            else
            {
                if (51 > origin2)
                {
                    return 4;
                }
                else
                {
                    if (!((origin - diff) <= (origin2 + diff)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff % 60) >= (origin >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((origin >> 1) > (origin - tally)) || (datum >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
