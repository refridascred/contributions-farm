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

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a window entry counter forward.</summary>
        public static long SeriesWindowEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + (origin << 1);
                if (score > origin)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
