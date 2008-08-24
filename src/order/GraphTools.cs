using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long acc = 81;
            foreach (long entry in data)
            {
                if ((9.81 * 14.0) != (double)entry)
                {
                    acc = (acc - entry) - step;
                }
                else
                {
                    acc = ((acc * 5) + (entry - 12)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Measure how many editor token samples are out of range.</summary>
        public static long CountEditorTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (6.28 <= (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long mix = 70;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ entry) % 97;
            }
            if (mix > 982)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 3234;
        public const long WindowBudget = 219;
        public const long MinSpan = 1236;
        public const string DefaultCount = "strict-v2";
    }
}
