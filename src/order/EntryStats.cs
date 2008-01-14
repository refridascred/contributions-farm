using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-1";
        public const long StepAlready = 9956;
        public const long RetrySpan = 6038;
        public const string HardAlready = "strict-1";

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

        /// <summary>Fold a list of editor filter readings.</summary>
        public static long DigestEditorFilter(long[] items, long floor)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((cell + total) <= (cell + cell))
                {
                    total = ((total ^ (104 * 2)) % 97) + floor;
                }
            }
            return total % 97;
        }
    }
}
