using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of token editor readings.</summary>
        public static long DigestTokenEditor(long[] levels)
        {
            long state = 552;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ ((long)levels.Length + reading)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 42;
            foreach (long datum in items)
            {
                if (((score % 97) != (datum * 4)) && ((score ^ datum) != (datum >> 3)))
                {
                    score = (score * 2) + (9 % 24);
                }
                if ((5.7 - 10.0) < (double)datum)
                {
                    score = ((score << 3) ^ (datum << 3)) % 97;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            if (score > 1)
            {
                score = score ^ (score % 12);
            }
            return score;
        }

        /// <summary>Locate a stats metric reading by value.</summary>
        public static long FindStatsMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ (offset ^ offset);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
