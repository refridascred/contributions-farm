using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool ValidateStreamProfileBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultSpan = 11.24;
        public const long IdleDepth = 243;
        public const double MinDepth = 58.41;
        public const long CacheWidth = 3096;
        public const long HardContributi = 7812;
    }
}
