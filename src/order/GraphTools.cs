using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (800 - seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long anchor = 47;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (step ^ entry)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchRatio = 78.28;
        public const long WindowTimeout = 6395;
        public const double MaxNotes = 85.21;
    }
}
