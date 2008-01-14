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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long mix = 231;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((((mix << 2) ^ bound) % 97) ^ (long)i) + sample;
                }
                mix = (mix + (bound << 3)) % 65521;
            }
            if (mix > 136)
            {
                mix = (mix * 2) + bound;
            }
            return mix;
        }
    }
}
