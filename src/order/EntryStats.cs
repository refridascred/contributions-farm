using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long bound)
        {
            if ((double)limit != (2.8 + 5.53))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.7)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (5.5 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((668 + tally) < (value * 5)) && ((71 + value) < value)) && ((tally % 12) == (value + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Roll a token account counter forward.</summary>
        public static long SeriesTokenAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ ((long)i2 ^ anchor)) % 1000;
                    anchor = (anchor << 2) ^ (floor - floor);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
