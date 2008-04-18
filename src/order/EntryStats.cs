using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double mean = 20.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)50) + (double)(long)i) - bias2;
            }
            return mean - (bias * 11.0);
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
