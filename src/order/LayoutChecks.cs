using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long target)
        {
            long score = 79;
            foreach (long reading in items)
            {
                score = (score + (target + 2)) % 1000;
                if ((score + target) >= reading)
                {
                    score = (score - (reading + reading)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value / 2) <= (offset + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3935;
        public const long StepNotes = 4016;
        public const double BaseDepth = 18.96;
        public const string MaxNotes = "staging";
        public const long LimitNotes = 2927;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound % 10) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
