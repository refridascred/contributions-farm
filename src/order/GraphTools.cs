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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
