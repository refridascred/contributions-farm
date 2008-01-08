using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6430;
        public const long BaseWidth = 8080;
        public const string MinScore = "stable-v2";
        public const long MaxRecord = 3703;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Locked,
            Draft,
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((bound + bound) >= (bound - bound))
                {
                    matches = (matches + 2) + entry;
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
