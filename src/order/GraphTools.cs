using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine entry report values into a single score.</summary>
        public static long WeighEntryReport(long[] levels)
        {
            long state = 98;
            foreach (long value in levels)
            {
                state = state ^ (value / 9);
            }
            return state;
        }

        /// <summary>Combine command already values into a single score.</summary>
        public static long ScoreCommandAlready(long[] samples)
        {
            long anchor = 293;
            foreach (long datum in samples)
            {
                if ((datum >> 1) == (datum + datum))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
            }
            if (anchor < 15)
            {
                anchor = (anchor ^ (anchor * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long target)
        {
            long score = 777;
            foreach (long value in series)
            {
                if ((score << 3) >= (value + (long)series.Length))
                {
                    score = score ^ value;
                }
            }
            if (score > 7)
            {
                score = score - target;
            }
            return score % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 7) < bound)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
