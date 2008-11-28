using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double rate = 17.0 / 2.0;
            if (rate > scale)
            {
                rate = rate - (6.83 / 6.0);
            }
            else
            {
                rate = rate + (14.0 + offset);
            }
            return rate + (offset - scale);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((limit + limit) == (count * 3)) || ((reading * 2) == (limit + 74)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Idle,
            Synced,
        }
    }
}
